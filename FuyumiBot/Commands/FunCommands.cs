using DSharpPlus.CommandsNext;
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
        [Description("Checks lag")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong")
                .ConfigureAwait(false);
        }

        [Command("Hello")]
        [Description("Says hello to Fuyumi!")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Hello {ctx.Member.Mention} I am Fuyumi! I was made by Revellia to help with many things!")
                .ConfigureAwait(false);
        }

        [Command("Info")]
        [Description("Gives info on Fuyumi")]
        public async Task Info(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("If you want info on me find my source code and more at https://github.com/Revellia/FuyumiBot")
                .ConfigureAwait(false);
        }

        [Command("Add")]
        [Description("Adds two numbers together")]
        public async Task Add(CommandContext ctx,
            [Description("First Number")] double numberOne,
            [Description("Second Number")] double numberTwo)
        {
            await ctx.Channel.SendMessageAsync((numberOne + numberTwo)
                .ToString())
                .ConfigureAwait(false);
        }

    }
}
