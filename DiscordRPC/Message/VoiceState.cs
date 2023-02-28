using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    internal class VoiceState
    {
        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("deaf")]
        public bool Deaf { get; set; }

        [JsonProperty("self_mute")]
        public bool SelfMute { get; set; }

        [JsonProperty("self_deaf")]
        public bool SelfDeaf { get; set; }

        [JsonProperty("suppress")]
        public bool Suppress { get; set; }
    }
}

