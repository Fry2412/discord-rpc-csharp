using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    public class VoiceStateUpdatedMessage : IMessage
    {

        [JsonProperty("evt")]
        public override MessageType Type => MessageType.VoiceStateUpdated;

        [JsonProperty("data")]
        public UserVoiceState Data { get; set; }

    }
}