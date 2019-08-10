using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EightbornLauncher
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private Thread second_thread;

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            int bIndex = rnd.Next(Variables.backgrounds.Length);
            mainPanel.BackgroundImage = Variables.backgrounds[bIndex];

            Variables.setVariables();
            labelVersion.Text = Variables.version;

            AddDrag(mainPanel);
            AddDrag(headerPanel);
            AddDrag(pictureBoxLogo);
            progressBar.Visible = false;

            webBrowser.Navigate(Variables.webbrowser_link + "?refreshToken = " + Guid.NewGuid().ToString());
            webBrowser.Refresh(WebBrowserRefreshOption.Completely);

            thread = new Thread(
              () =>
              {
                  try
                  {
                      using (WebClient client = new WebClientWithTimeout())
                      {
                          string webData = null;
                          try
                          {
                              webData = client.DownloadString("http://"+Variables.getIP()+"/info.json");
                          }
                          catch (Exception e)
                          {
                              Console.WriteLine("Error(info.json):" + e.Message);
                          }
                          finally
                          {
                              Variables.server_status = (String.IsNullOrEmpty(webData) ? false : true);
                          }
                      }
                  }
                  catch(Exception e)
                  {
                      Console.WriteLine(e.Message);
                  }
              });
            thread.Start();

            second_thread = new Thread(
              () =>
              {
                  try
                  {
                      while (thread.IsAlive)
                      {
                          Thread.Sleep(100);
                      }
                      if (!Variables.server_status) pictureBoxSunucuDurum.BackgroundImage = Properties.Resources.kilitli;
                      if (!Variables.status) pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.kilitli;
                  }
                  catch(Exception e)
                  {
                      Console.WriteLine(e.Message);
                  }
              });
            second_thread.Start();

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://eightbornv.com");
            request.AllowAutoRedirect = false;
            request.Method = "HEAD";
            try
            {
                WebResponse response = request.GetResponse();
            }
            catch (WebException)
            {
                pictureBoxSiteDurum.BackgroundImage = Properties.Resources.kilitli;
            }

            /*Timer MyTimer = new Timer();
            MyTimer.Interval = (1 * 60 * 1000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();*/
        }

        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonOyna_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
                return;

            Variables.setVariables();
            DialogResult result;
            if (EightbornLauncher.Update.checkUpdate())
            {
                result = MessageBox.Show("Oyuna bağlanabilmeniz için launcher güncellemesi gerekli.\nGüncelleştirmek istiyor musunuz?", "Güncelleme Gerekli", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    doUpdate();
                    buttonOyna.Enabled = false;
                }
            }
            else
            {
                Variables.setVariables();

                using (WebClient client = new WebClientWithTimeout())
                {
                    string webData = null;
                    try
                    {
                        webData = client.DownloadString("http://"+Variables.getIP()+"/info.json");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error(info.json):"+ex.Message);
                    }
                    Variables.server_status = (String.IsNullOrEmpty(webData) ? false : true);
                }

                if (!Variables.status)
                {
                    MessageBox.Show("Sunucuya girişler şu anda kapalı durumdadır!", "HATA", MessageBoxButtons.OK);
                    pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.kilitli;
                    return;
                }
                else pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.acik;

                if (!Variables.server_status)
                {
                    MessageBox.Show("Sunucu şu an bakım durumundadır!", "HATA", MessageBoxButtons.OK);
                    pictureBoxSunucuDurum.BackgroundImage = Properties.Resources.kilitli;
                    return;
                }

                Process.Start("fivem://connect/"+Variables.getIP());
            }
        }

        private void doUpdate()
        {
            progressBar.Visible = true;
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFile(Variables.launcher_link, "EightbornLauncher2.exe");
            }
            progressBar.Value = 100;

            string cmd = "/C taskkill /IM "+ System.AppDomain.CurrentDomain.FriendlyName.ToString() + " && timeout 1 >nul && del "+ System.AppDomain.CurrentDomain.FriendlyName.ToString() + " && ren EightbornLauncher2.exe EightbornLauncher.exe && start EightbornLauncher.exe";
            Process.Start("cmd", cmd);
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void ButtonSite_Click(object sender, EventArgs e)
        {
            Process.Start("http://eightbornv.com");

        }

        private void ButtonOyna_MouseEnter(object sender, EventArgs e)
        {
            buttonOyna.BackgroundImage = Properties.Resources.baslat2;
        }

        private void ButtonOyna_MouseLeave(object sender, EventArgs e)
        {
            buttonOyna.BackgroundImage = Properties.Resources.start1;
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.close21;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.close;
        }

        private void ButtonMinimize_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimize.BackgroundImage = Properties.Resources.minimize2;
        }

        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimize.BackgroundImage = Properties.Resources.minimize;
        }

        private void ButtonSite_MouseEnter(object sender, EventArgs e)
        {
            buttonSite.ForeColor = Color.FromArgb(180, 180, 180);
        }

        private void ButtonSite_MouseLeave(object sender, EventArgs e)
        {
            buttonSite.ForeColor = Color.FromArgb(249, 249, 249);
        }

        /*private void MyTimer_Tick(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                Variables.server_status = Convert.ToBoolean(client.DownloadString(Variables.getinfo_link).ToString());
                if (Variables.server_status)
                {
                    labelOnlineSayi.Text = client.DownloadString(Variables.getonline_link).ToString();
                }
                else
                {
                    pictureBoxSunucuDurum.BackgroundImage = Properties.Resources.kilitli;
                    labelOnlineSayi.Text = "0 / 128";
                }
            }

            if (!Variables.status) pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.kilitli;
        }*/
    }
}
