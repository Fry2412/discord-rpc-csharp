using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    public class VoiceStateData
    {
        [JsonProperty("voice_state")]
        public VoiceState State { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("nick")]
        public string Nick { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("pan")]
        public object Pan { get; set; }
    }

    public class Pan
    {
        [JsonProperty("left")]
        public float Left { get; set; }

        [JsonProperty("right")]
        public float Right { get; set; }
    }
}

