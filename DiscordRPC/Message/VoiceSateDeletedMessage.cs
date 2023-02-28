using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    internal class VoiceSateDeletedMessage : IMessage
    {
        [JsonProperty("evt")]
        public override MessageType Type => MessageType.VoiceStateCreated;

        [JsonProperty("data")]
        public VoiceStateData Data { get; set; }

    }
}