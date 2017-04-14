﻿using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class TimeModule : ModuleBase
    {
        // ~time -> 14:38:01
        [Command("time"), Summary("Echos a message.")]
        public async Task Time()
        {
            // ReplyAsync is a method on ModuleBase
            await ReplyAsync(DateTime.UtcNow.ToString("HH:mm:ss" + " UTC"));
        }
    }
}
