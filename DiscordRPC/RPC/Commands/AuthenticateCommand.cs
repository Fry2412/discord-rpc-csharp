using DiscordRPC.RPC.Payload;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRPC.RPC.Commands
{
    internal class AuthenticateCommand : ICommand
    {
        [JsonProperty("client_id")]
        public string ClientId { get { return "1072421581743194122"; } }
        [JsonProperty("scopes")]
        public List<string> Scopes { get { return new List<string>() { "rpc", "rpc.notification.read" }; } }


        public IPayload PreparePayload(long nonce)
        {
            return new ArgumentPayload(this, nonce)
            {
                Command = Command.Authenticate
            };
        }
    }
}
