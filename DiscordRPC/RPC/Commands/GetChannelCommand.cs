using DiscordRPC.RPC.Payload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordRPC.RPC.Commands
{
    internal class GetChannelCommand : ICommand
    {

        public IPayload PreparePayload(long nonce)
        {
            return new ArgumentPayload(this, nonce)
            {
                Command = Command.GetSelectedVoiceChannel
            };
        }
    }
}
