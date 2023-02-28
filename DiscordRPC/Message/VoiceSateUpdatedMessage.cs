using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    internal class VoiceSateUpdatedMessage : IMessage
    {

        [JsonProperty("evt")]
        public override MessageType Type => MessageType.VoiceStateUpdated;

        [JsonProperty("data")]
        public VoiceStateData Data { get; set; }

    }
}