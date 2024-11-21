using Line.Messaging;
using Line.Messaging.Webhooks;
using Line.MessageApi.CloudStorage;
using Line.MessageApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Line.MessageApi
{
    internal class LineBotApp : WebhookApplication
    {
        private LineMessagingClient messagingClient { get; }
        private TableStorage<EventSourceState> sourceState { get; }
        private BlobStorage blobStorage { get; }

        public LineBotApp(LineMessagingClient lineMessagingClient, TableStorage<EventSourceState> tableStorage, BlobStorage blobStorage)
        {
            this.messagingClient = lineMessagingClient;
            this.sourceState = tableStorage;
            this.blobStorage = blobStorage;
        }

        #region Handlers

        protected override async Task OnMessageAsync(MessageEvent ev)
        {
            switch (ev.Message.Type)
            {
                case EventMessageType.Text:
                    await HandleTextAsync(ev.ReplyToken, ((TextEventMessage)ev.Message).Text, ev.Source.UserId);
                    break;
                case EventMessageType.Image:
                case EventMessageType.Audio:
                case EventMessageType.Video:
                case EventMessageType.File:
                    // Prepare blob directory name for binary object.
                    var blobDirectoryName = ev.Source.Type + "_" + ev.Source.Id;
                    await HandleMediaAsync(ev.ReplyToken, ev.Message.Id, blobDirectoryName, ev.Message.Id);
                    break;
                case EventMessageType.Location:
                    var location = ((LocationEventMessage)ev.Message);
                    await HandleLocationAsync(ev.ReplyToken, location);
                    break;
                case EventMessageType.Sticker:
                    await HandleStickerAsync(ev.ReplyToken);
                    break;
            }
        }

        protected override async Task OnPostbackAsync(PostbackEvent ev)
        {
            switch (ev.Postback.Data)
            {
                case "Date":
                    await messagingClient.ReplyMessageAsync(ev.ReplyToken,
                        "You chose the date: " + ev.Postback.Params.Date);
                    break;
                case "Time":
                    await messagingClient.ReplyMessageAsync(ev.ReplyToken,
                        "You chose the time: " + ev.Postback.Params.Time);
                    break;
                case "DateTime":
                    await messagingClient.ReplyMessageAsync(ev.ReplyToken,
                        "You chose the date-time: " + ev.Postback.Params.DateTime);
                    break;
                default:
                    await messagingClient.ReplyMessageAsync(ev.ReplyToken,
                        "Your postback is " + ev.Postback.Data);
                    break;
            }
        }

        protected override async Task OnFollowAsync(FollowEvent ev)
        {
            // Store source information which follows the bot.
            await sourceState.AddAsync(ev.Source.Type.ToString(), ev.Source.Id);

            var userName = "";
            if (!string.IsNullOrEmpty(ev.Source.Id))
            {
                var userProfile = await messagingClient.GetUserProfileAsync(ev.Source.Id);
                userName = userProfile?.DisplayName ?? "";
            }

            await messagingClient.ReplyMessageAsync(ev.ReplyToken, $"Hello {userName}! Thank you for following !");
        }

        protected override async Task OnUnfollowAsync(UnfollowEvent ev)
        {
            // Remote source information which unfollows the bot.
            await sourceState.DeleteAsync(ev.Source.Type.ToString(), ev.Source.Id);
        }

        protected override async Task OnJoinAsync(JoinEvent ev)
        {
            await messagingClient.ReplyMessageAsync(ev.ReplyToken, $"Thank you for letting me join your {ev.Source.Type.ToString().ToLower()}!");
        }

        protected override async Task OnLeaveAsync(LeaveEvent ev)
        {
            await sourceState.DeleteAsync(ev.Source.Type.ToString(), ev.Source.Id);
        }

        protected override async Task OnBeaconAsync(BeaconEvent ev)
        {
            var message = "";
            switch (ev.Beacon.Type)
            {
                case BeaconType.Enter:
                    message = "You entered the beacon area!";
                    break;
                case BeaconType.Leave:
                    message = "You leaved the beacon area!";
                    break;
                case BeaconType.Banner:
                    message = "You tapped the beacon banner!";
                    break;
            }

            await messagingClient.ReplyMessageAsync(ev.ReplyToken, $"{message}(Dm:{ev.Beacon.Dm}, Hwid:{ev.Beacon.Hwid})");
        }

        #endregion

        private async Task HandleTextAsync(string replyToken, string userMessage, string userId)
        {
            userMessage = userMessage.ToLower().Replace(" ", "");
            ISendMessage replyMessage = null;

            replyMessage = new TextMessage(@"ทดสอบส่งข้อความแจ้งเตือน !!!");

            //create broad cast method and try
            await messagingClient.BroadcastMessageAsync(new List<ISendMessage> { replyMessage });
        }

        /// <summary>
        /// Upload the received data to blob and returns the address
        /// </summary>
        private async Task HandleMediaAsync(string replyToken, string messageId, string blobDirectoryName, string blobName)
        {
            var stream = await messagingClient.GetContentStreamAsync(messageId);
            var ext = GetFileExtension(stream.ContentHeaders.ContentType.MediaType);
            var uri = await blobStorage.UploadFromStreamAsync(stream, blobDirectoryName, blobName + ext);
            await messagingClient.ReplyMessageAsync(replyToken, uri.ToString());
        }

        /// <summary>
        /// Reply the location user send.
        /// </summary>
        private async Task HandleLocationAsync(string replyToken, LocationEventMessage location)
        {
            await messagingClient.ReplyMessageAsync(replyToken, new[] {
                        new LocationMessage("Location", location.Address, location.Latitude, location.Longitude)
                    });
        }

        /// <summary>
        /// Replies random sticker
        /// Sticker ID of bssic stickers (packge ID =1)
        /// see https://devdocs.line.me/files/sticker_list.pdf
        /// </summary>
        private async Task HandleStickerAsync(string replyToken)
        {
            var stickerids = Enumerable.Range(1, 17)
                .Concat(Enumerable.Range(21, 1))
                .Concat(Enumerable.Range(100, 139 - 100 + 1))
                .Concat(Enumerable.Range(401, 430 - 400 + 1)).ToArray();

            var rand = new Random(Guid.NewGuid().GetHashCode());
            var stickerId = stickerids[rand.Next(stickerids.Length - 1)].ToString();
            await messagingClient.ReplyMessageAsync(replyToken, new[] {
                        new StickerMessage("1", stickerId)
                    });
        }

        private string GetFileExtension(string mediaType)
        {
            switch (mediaType)
            {
                case "image/jpeg":
                    return ".jpeg";
                case "audio/x-m4a":
                    return ".m4a";
                case "video/mp4":
                    return ".mp4";
                default:
                    return "";
            }
        }
    }
}