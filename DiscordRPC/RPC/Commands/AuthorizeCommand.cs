using DiscordRPC.RPC.Payload;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRPC.RPC.Commands
{
    internal class AuthorizeCommand : ICommand
    {
        private string _accvessToken;

        [JsonProperty("access_token")]
        public string AccessToken { get { return _accvessToken; } }

        [JsonProperty("client_id")]
        public string ClientId { get { return "1072421581743194122"; } }

        public AuthorizeCommand(string accessToken)
        {
            _accvessToken = accessToken;
        }

        public IPayload PreparePayload(long nonce)
        {
            return new ArgumentPayload(this, nonce)
            {
                Command = Command.Authorize
            };
        }
    }
}
