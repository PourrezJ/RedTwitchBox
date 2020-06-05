using System.Collections.Generic;

namespace RedTwitchBox
{
    public class Settings
    {
        public string ChannelName;
        public string AccessToken;
        public List<BasicCommand> Commands;

        public Settings(string channelName, string accessToken)
        {
            ChannelName = channelName;
            AccessToken = accessToken;
        }
    }
}
