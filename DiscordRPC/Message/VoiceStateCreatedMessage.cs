using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace DiscordRPC.Message
{
    public class VoiceStateCreatedMessage : IMessage
    {

        [JsonProperty("evt")]
        public override MessageType Type => MessageType.VoiceStateCreated;

        [JsonProperty("data")]
        public UserVoiceState Data { get; set; }

    }
}

