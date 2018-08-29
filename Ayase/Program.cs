using System;
using Ayase.Discord;
using Ayase.Discord.Entities;

namespace Ayase
{
    internal class Program
    {
        public static void Main()
        {   
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var discordBotConfig = new AyaseConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}
