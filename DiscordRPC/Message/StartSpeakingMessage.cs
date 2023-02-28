using DiscordRPC.RPC.Payload;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordRPC.Message
{
    public class StartSpeakingMessage : IMessage
    {
        public override MessageType Type => MessageType.SpeakingStart;

        [JsonProperty("evt")]
        public ServerEvent Event { get; internal set; }

        [JsonProperty("data")]
        public ChannelUser Data { get; internal set; }

    }
}
