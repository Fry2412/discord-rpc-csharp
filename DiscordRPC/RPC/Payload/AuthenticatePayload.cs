using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRPC.RPC.Payload
{
    internal class AuthenticatePayload: IPayload
    {
        [JsonProperty("code")]
        public string Code { get; set; }

    }
}
