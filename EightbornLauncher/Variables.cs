using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace EightbornLauncher
{
    class Variables
    {
        public static string version = "v 1.0.5";
        public static string version_link = "http://eightbornv.site/eightborn-launcher/version.txt";
        public static string launcher_link = "http://eightbornv.site/eightborn-launcher/launcher.exe";
        public static string webbrowser_link = "http://eightbornv.site/eightborn-launcher/html/index.html";
        //public static string getinfo_link = "http://eightbornv.site/eightborn-launcher/getinfo1.php";
        //public static string getonline_link = "http://eightbornv.site/eightborn-launcher/getonline1.php";
        public static string variables_link = "http://eightbornv.site/eightborn-launcher/variables.txt";
        public static bool status = true;
        public static bool server_status = true;
        private static string server_ip = "185.126.178.56:30120";
        public static System.Drawing.Bitmap[] backgrounds = new System.Drawing.Bitmap[]
            {
                Properties.Resources._707058,
                Properties.Resources._707058,
                Properties.Resources._707072,
                Properties.Resources._707179,
                Properties.Resources._853486
                /*Properties.Resources._1280x720_2745980_grand_theft_auto_v_4k_background_wallpaper,*/
            };

        public static string getIP()
        {
            return server_ip;
        }

        public static void setVariables()
        {
            using (WebClient client = new WebClientWithTimeout())
            {
                status = Convert.ToBoolean(client.DownloadString(Variables.variables_link).Split(';').GetValue(0).ToString());
                //server_ip = client.DownloadString(Variables.variables_link).Split(';').GetValue(1).ToString();
            }
        }
    }
}
