using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RedTwitchBox
{
    public class Settings
    {
        public string ChannelName;
        public string AccessToken;

        private List<BasicCommand> commands;
        public List<BasicCommand> Commands
        {
            get
            {
                if (commands == null)
                    commands = new List<BasicCommand>();
                return commands;
            }
            set => commands = value;
        }

        public Settings(string channelName, string accessToken)
        {
            ChannelName = channelName;
            AccessToken = accessToken;
        }

        public void Save()
        {
            File.WriteAllText(Path.Combine(Program.ApplicationPath, "Settings.json"), JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public bool CheckIfCommandExist(string commandName)
        {
            return Commands.Exists(p => p.name == commandName);
        }

        public BasicCommand GetCommand(string commandName)
        {
            return Commands.Find(p => p.name == commandName);
        }
    }
}
