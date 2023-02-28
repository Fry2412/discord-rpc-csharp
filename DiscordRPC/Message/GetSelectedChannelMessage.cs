using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordRPC.Message
{
    public class GetSelectedChannelMessage : IMessage
    {
        public override MessageType Type => MessageType.GetSelectedVoiceChannel;

        [JsonProperty("data")]
        public ChannelData ChannelData { get; set; }
    }

    public class ChannelData
    {
        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty("guild_id")]
        public string GuildId { get; set; }

        [JsonProperty("id")]
        public string ChannelId { get; set; }

        [JsonProperty("name")]
        public string ChannelName { get; set; }

        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }

        [JsonProperty("voice_states")]
        public List<UserVoiceState> VoiceStates { get; set; }
    }

    public class UserVoiceState
    {
        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("nick")]
        public string NickName { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("voice_state")]
        public VoiceState VoiceState { get; set; }
    }

}