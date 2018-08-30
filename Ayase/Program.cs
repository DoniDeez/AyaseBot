using System;
using System.Threading.Tasks;
using Ayase.Discord;
using Ayase.Discord.Entities;
using Ayase.Storage;
using Discord.WebSocket;

namespace Ayase
{
    internal class Program
    {
        public static async Task Main()
        {   
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new AyaseConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.ReadKey();
        }
    }
}