using System;
using System.Collections.Generic;
using System.Text;

namespace RedTwitchBox
{
    public class BasicCommand
    {
        public string name;
        public string response;

        public static void AddBasicCommand(string name, string response)
        {
            var command = new BasicCommand()
            {
                name = name,
                response = response
            };

            Program.Settings.Commands.Add(command);
            Program.Settings.Save();
        }
    }
}
