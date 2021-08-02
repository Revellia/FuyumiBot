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
        //This command is huge and complicated
        [Command("Warn")]
        [Description("Warns the user")]
        [RequireRoles(RoleCheckMode.Any, "Fuyumi's Creator", "Owner", "Moderator", "Administrator")]
        public async Task Warn(CommandContext ctx,
    [Description("Message to warn with | \"Example warning\"")] string WarningMessage,
    [Description("User to warn | @ExampleUser")] string WarnUser)
        {
            if (WarningMessage.Contains("@")){

                await ctx.Member.SendMessageAsync("Command typed incorrectly, check ?help warn")
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
