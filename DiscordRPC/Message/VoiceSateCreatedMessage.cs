using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace DiscordRPC.Message
{
    internal class VoiceSateCreatedMessage : IMessage
    {

        [JsonProperty("evt")]
        public override MessageType Type => MessageType.VoiceStateCreated;

        [JsonProperty("data")]
        public VoiceStateData Data { get; set; }

    }
}

