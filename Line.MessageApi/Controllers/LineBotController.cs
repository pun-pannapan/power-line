using Line.MessageApi.CloudStorage;
using Line.MessageApi.Models;
using Line.Messaging.Webhooks;
using Line.Messaging;
using System.Configuration;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Line.MessageApi.Controllers
{
    public class LineBotController : ApiController
    {
        private static LineMessagingClient lineMessagingClient;
        private string accessToken = ConfigurationManager.AppSettings["ChannelAccessToken"];
        private string channelSecret = ConfigurationManager.AppSettings["ChannelSecret"];
        public LineBotController()
        {
            lineMessagingClient = new LineMessagingClient(accessToken);
        }

        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        [HttpPost]
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            var events = await request.GetWebhookEventsAsync(channelSecret);
            var connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];
            var blobStorage = await BlobStorage.CreateAsync(connectionString, "linebotcontainer");
            var eventSourceState = await TableStorage<EventSourceState>.CreateAsync(connectionString, "eventsourcestate");

            var app = new LineBotApp(lineMessagingClient, eventSourceState, blobStorage);
            await app.RunAsync(events);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}