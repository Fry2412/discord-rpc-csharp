﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DiscordRPC.RPC.Payload;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiscordRPC.RPC.Commands
{
    internal class SubscribeCommand : ICommand
    {
        private string? _channelId;

        public ServerEvent Event { get; set; }
        public bool IsUnsubscribe { get; set; }

        public SubscribeCommand(string channelId = null)
        {
            _channelId = channelId;
        }

        public IPayload PreparePayload(long nonce)
        {
            JObject arg = null;
            if (!String.IsNullOrEmpty(_channelId))
            {
                arg = new JObject
                {
                    new JProperty("channel_id", _channelId)
                };
            }
            return new EventPayload(nonce)
            {
                Command = IsUnsubscribe ? Command.Unsubscribe : Command.Subscribe,
                Event = Event,
                Arguments = arg
            };
        }
    }
}
