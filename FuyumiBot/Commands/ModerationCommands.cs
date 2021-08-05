using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuyumiBot.Commands
{
    class ModerationCommands : BaseCommandModule
    {
        //This command still isn't completely bug free but I'm not sure how to fix it. Users can't mention another user in warning msg
        [Command("Warn")]
        [Description("Warns the user")]
        [RequireRoles(RoleCheckMode.Any, "Fuyumi's Creator", "Owner", "Moderator", "Administrator")]
        public async Task Warn(CommandContext ctx,
    [Description("Message to warn with (Can't use mentions in message) | \"Example warning\"")] string WarningMessage,
    [Description("User to warn | @ExampleUser")] string WarnUser)
        {
            if (WarningMessage.Contains("@")){

                await ctx.Member.SendMessageAsync("Command typed incorrectly you can't use mentions in your warning, check ?help warn for more info")
                    .ConfigureAwait(false);
            } else if (WarnUser.Contains("@"))
            {
                await ctx.Channel.SendMessageAsync($"{WarnUser} has been warned by a staff member | {WarningMessage}")
                    .ConfigureAwait(false);
            } else
            {
                await ctx.Member.SendMessageAsync("Command typed incorrectly, make sure you are mentioning the user you are trying to warn")
                    .ConfigureAwait(false);
            }
        }
    }
}
