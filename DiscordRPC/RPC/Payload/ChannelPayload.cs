using DiscordRPC.Converters;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRPC.RPC.Payload
{
    internal class ChannelPayload : IPayload
    {
        /// <summary>
        /// The data the server sent too us
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Data { get; set; }

        /// <summary>
        /// The type of event the server sent
        /// </summary>
        [JsonProperty("evt"), JsonConverter(typeof(EnumSnakeCaseConverter))]
        public ServerEvent? Event { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        public ChannelPayload(long nonce) : base(nonce) { Data = null; }
    }
}
