using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using SimpleSlideShow.Bot.Services;

namespace SimpleSlideShow.Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = GetConfiguration();

            var token = configuration["api-token"];
            var saveImagesTo = configuration["saveImagesTo"];
            var startEnabled = "true".Equals(configuration["startEnabled"], StringComparison.InvariantCultureIgnoreCase);
            var telegram = new TelegramService(token, saveImagesTo, startEnabled);

            Console.WriteLine($"Start listening...");
            telegram.StartBot();
            Console.ReadLine();

            Console.WriteLine($"Stop listening...");
            telegram.StopBot();
            Console.WriteLine($"Bye bye.");
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);

            builder.AddJsonFile("appsettings.dev.json", true, true);

            return builder.Build();
        }
    }
}
