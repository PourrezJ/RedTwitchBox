using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace RedTwitchBox
{
    class Program
    {
        public static string ApplicationPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static Bot bot;

        public static Settings Settings;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting RedTwitchBox...");

            if (!File.Exists(Path.Combine(ApplicationPath, "Settings.json")))
            {
                Console.WriteLine("Settings.json is missing, first start?");


                Console.WriteLine("\nWhat is the channel name? \nWrite the name and press Enter.");
                var channelName = Console.ReadLine();
                Console.WriteLine("ChannelName is " + channelName);


                Console.WriteLine("\nWhat is the access Token? \nWrite the name and press Enter.");
                var accessToken = Console.ReadLine();
                Console.WriteLine("Access Token is " + accessToken);

                Settings = new Settings(channelName, accessToken);
                Settings.Save();
            }
            else
            {
                Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Path.Combine(ApplicationPath, "Settings.json")));
            }

            bot = new Bot(Settings.ChannelName, Settings.AccessToken);

            Console.ReadLine();
        }
    }
}
