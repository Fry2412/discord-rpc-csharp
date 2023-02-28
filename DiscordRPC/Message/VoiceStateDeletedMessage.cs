using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    public class VoiceStateDeletedMessage : IMessage
    {
        [JsonProperty("evt")]
        public override MessageType Type => MessageType.VoiceStateDeleted;

        [JsonProperty("data")]
        public UserVoiceState Data { get; set; }

    }
}