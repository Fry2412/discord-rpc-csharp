using DiscordRPC.Message;
using Newtonsoft.Json;

namespace DiscordRPC.RPC
{
    public class VoiceChannelSelectedMessage : IMessage
    {
        public override MessageType Type => MessageType.VoiceChannelSelected;

        [JsonProperty("data")]
        public ChannelInfo ChannelData { get; set; }


    }

    public class ChannelInfo
    {
        [JsonProperty("guild_id")]
        public string GuildID { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }
    }
}