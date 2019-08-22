using System;
using System.Net;

namespace EightbornLauncher
{
    class Variables
    {
        public static string version = "v 1.0.9";
        public static string version_link = "http://eightbornv.site/eightborn-launcher/version.txt";
        public static string launcher_link = "http://eightbornv.site/eightborn-launcher/launcher.exe";
        public static string webbrowser_link = "http://eightbornv.site/eightborn-launcher/html/index.html";
        public static string variables_link = "http://eightbornv.site/eightborn-launcher/variables.txt";
        public static string dl_link = "http://eightbornv.site/eightborn-launcher/dl/";
        public static string[] files = new string[] {
             "citizen\\common\\data\\ui\\mapzoomdata.meta",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_0_0.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_0_1.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_1_0.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_1_1.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_2_0.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_2_1.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_lod_128.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_sea_0_0.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_sea_0_1.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_sea_1_0.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_sea_1_1.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_sea_2_0.ytd",
             "citizen\\platform\\data\\cdimages\\scaleform_generic\\minimap_sea_2_1.ytd"
        };
        public static bool status = true;
        public static bool server_status = true;
        private static readonly string server_ip = "185.126.178.60:30120";
        public static System.Drawing.Bitmap[] backgrounds = new System.Drawing.Bitmap[]
            {
                Properties.Resources._707058,
                Properties.Resources._707058,
                Properties.Resources._707072,
                Properties.Resources._707179,
                Properties.Resources._853486
            };

        public static string GetIP()
        {
            return server_ip;
        }

        public static void SetVariables()
        {
            using (WebClient client = new WebClientWithTimeout())
            {
                status = Convert.ToBoolean(client.DownloadString(Variables.variables_link).Split(';').GetValue(0).ToString());
            }
        }
    }
}
