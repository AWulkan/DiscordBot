using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    // Create a module with the 'math' prefix
    [Group("math"), Summary("A collection of math related commands.")]
    public class MathModule : ModuleBase
    {
        // ~math square 20 -> 400.
        [Command("square"), Summary("Squares a number.")]
        public async Task Square([Summary("The number to square")] int num)
        {
            await ReplyAsync($"{num}^2 = {Math.Pow(num, 2)}");
        }
    }
}
