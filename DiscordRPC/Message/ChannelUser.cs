using Newtonsoft.Json;

namespace DiscordRPC.Message
{
    public class ChannelUser
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }


        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }
    }
}
