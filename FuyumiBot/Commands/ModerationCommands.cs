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
        [Command("Warn")]
        [Description("Warns the user")]
        [RequireRoles(RoleCheckMode.Any, "Fuyumi's Creator", "Owner", "Moderator", "Administrator")]
        public async Task Warn(CommandContext ctx,
    [Description("Message to warn with (Cover in quotations)")] string WarningMessage,
    [Description("User to warn (@ the user)")] string WarnUser)
        {
            if (WarningMessage.Contains("@")){

                await ctx.Member.SendMessageAsync("Command typed incorrectly, check ?help warn")
                    .ConfigureAwait(false);
            } else
            {
                await ctx.Channel.SendMessageAsync($"{WarnUser} has been warned by a staff member | {WarningMessage} ")
                    .ConfigureAwait(false);
            }
        }
    }
}
