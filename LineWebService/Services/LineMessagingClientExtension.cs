using Line.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Line.Messaging.

namespace LineWebService.Services
{
    public class LineMessagingClientExtension : LineMessagingClient
    {
        private const string DEFAULT_URI = "https://api.line.me/v2";

        private HttpClient _client;
        private JsonSerializerSettings _jsonSerializerSettings;
        private string _uri;

        public LineMessagingClientExtension(string channelAccessToken, string uri = "https://api.line.me/v2") : base(channelAccessToken, uri)
        {
        }

        /// <summary>
        /// Respond to events from users, groups, and rooms
        /// https://developers.line.me/en/docs/messaging-api/reference/#send-reply-message
        /// </summary>
        /// <param name="messages">Reply messages. Up to 5 messages.</param>
        public virtual async Task BroadcastMessageAsync(IList<ISendMessage> messages)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{_uri}/bot/message/broadcast");
            var content = JsonConvert.SerializeObject(new { messages }, _jsonSerializerSettings);
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request).ConfigureAwait(false);
            await response.EnsureSuccessStatusCodeAsync().ConfigureAwait(false);
        }
    }
}