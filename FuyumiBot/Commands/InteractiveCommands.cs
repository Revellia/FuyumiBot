using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuyumiBot.Commands
{
    class InteractiveCommands : BaseCommandModule
    {
        [Command("8Ball")]
        [Description("Ask the 8 Ball a question")]
        public async Task Magic8Ball(CommandContext ctx)
        {
            //Variables making the list random and defining the list
            var random = new Random();
            List<string> MagicList = new List<string> { "Yes", "No", "Maybe", "Sometimes", "Try Again", "Definitely Not", "Maybe in the Future"};
            int MagicRand = random.Next(MagicList.Count);

            await ctx.Channel.SendMessageAsync("Ask the 8 ball a question...")
                .ConfigureAwait(false);
            
            var interactivity = ctx.Client.GetInteractivity();
            //Interactively checks for the message to be send in the chat the bot command was called in
            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel)
                .ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(MagicList[MagicRand]);
        }
    }
}
