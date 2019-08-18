using Microsoft.Win32;
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
        private string fiveMLocation = null;

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            int bIndex = rnd.Next(Variables.backgrounds.Length);
            mainPanel.BackgroundImage = Variables.backgrounds[bIndex];

            Variables.SetVariables();
            labelVersion.Text = Variables.version;

            AddDrag(mainPanel);
            AddDrag(headerPanel);
            AddDrag(pictureBoxLogo);
            downloadLabel.Text = "";

            webBrowser.Navigate(Variables.webbrowser_link + "?refreshToken = " + Guid.NewGuid().ToString());
            webBrowser.Refresh(WebBrowserRefreshOption.Completely);

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\CitizenFX\\FiveM"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("Last Run Location");
                        if (o != null)
                        {
                            fiveMLocation = o.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            if (!Variables.status) pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.kilitli;

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
            BeginInvoke(new MethodInvoker(() => { progressBar.MarqueeAnimationSpeed = 30; downloadLabel.Text = "Dosyalar kontrol ediliyor.."; buttonOyna.Enabled = false; }));
            string file_location;
            foreach (string file in Variables.files)
            {
                file_location = fiveMLocation + file;
                if (!File.Exists(file_location))
                {
                    using (WebClient wc = new WebClient())
                    {
                        try
                        {
                            System.IO.Directory.CreateDirectory(file_location.Substring(0, file_location.LastIndexOf('\\')));
                            wc.DownloadFile(Variables.dl_link + file.Replace("\\", "/"), file_location);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            BeginInvoke(new MethodInvoker(() => { progressBar.MarqueeAnimationSpeed = 0; downloadLabel.Text = "Dosyalar kontrol edildi."; buttonOyna.Enabled = true; }));

            Variables.SetVariables();

            DialogResult result;
            if (EightbornLauncher.Update.checkUpdate())
            {
                result = MessageBox.Show("Oyuna bağlanabilmeniz için launcher güncellemesi gerekli.\nGüncelleştirmek istiyor musunuz?", "Güncelleme Gerekli", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DoUpdate();
                    buttonOyna.Enabled = false;
                }
            }
            else
            {
                Variables.SetVariables();

                if (!Variables.status)
                {
                    MessageBox.Show("Sunucuya girişler şu anda kapalı durumdadır!", "HATA", MessageBoxButtons.OK);
                    pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.kilitli;
                    return;
                }
                else pictureBoxSunucuGiris.BackgroundImage = Properties.Resources.acik;

                Process.Start("fivem://connect/" + Variables.GetIP());
            }
        }

        private void DoUpdate()
        {
            progressBar.Visible = true;
            downloadLabel.Visible = true;
            downloadLabel.Text = "Güncelleme indiriliyor..";

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(Variables.launcher_link, "EightbornLauncher2.exe");
            }

            string cmd = "/C taskkill /IM "+ System.AppDomain.CurrentDomain.FriendlyName.ToString() + " && timeout 1 >nul && del "+ System.AppDomain.CurrentDomain.FriendlyName.ToString() + " && ren EightbornLauncher2.exe EightbornLauncher.exe && start EightbornLauncher.exe";
            Process.Start("cmd", cmd);
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
    }
}
