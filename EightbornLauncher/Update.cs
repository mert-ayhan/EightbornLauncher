using System.Net;

namespace EightbornLauncher
{
    class Update
    {
        public static bool checkUpdate()
        {
            string last_version = null;

            using (WebClient client = new WebClientWithTimeout())
            {
                last_version = client.DownloadString(Variables.version_link);
            }

            return !last_version.Equals(Variables.version);
        }        
    }
}
