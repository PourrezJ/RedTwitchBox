namespace RedTwitchBox
{
    public class Settings
    {
        public string ChannelName;
        public string AccessToken;

        public Settings(string channelName, string accessToken)
        {
            ChannelName = channelName;
            AccessToken = accessToken;
        }
    }
}
