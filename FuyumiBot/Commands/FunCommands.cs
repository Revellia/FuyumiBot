﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuyumiBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("Ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }
        [Command("Hello")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello I am Fuyumi! I was made by Revellia to help with many things!").ConfigureAwait(false);
        }
        [Command("Info")]
        public async Task Info(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("If you want info on me find my source code and more at https://github.com/Revellia/FuyumiBot").ConfigureAwait(false);
        }
    }
}
