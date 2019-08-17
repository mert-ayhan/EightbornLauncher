namespace EightbornLauncher
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSite = new System.Windows.Forms.Button();
            this.buttonOyna = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pictureBoxSunucuGiris = new System.Windows.Forms.PictureBox();
            this.pictureBoxSiteDurum = new System.Windows.Forms.PictureBox();
            this.labelSunucuGiris = new System.Windows.Forms.Label();
            this.labelSiteDurum = new System.Windows.Forms.Label();
            this.pictureBoxSunucuDurum = new System.Windows.Forms.PictureBox();
            this.labelSunucuDurum = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunucuGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiteDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunucuDurum)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::EightbornLauncher.Properties.Resources._853486;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.downloadLabel);
            this.mainPanel.Controls.Add(this.progressBar);
            this.mainPanel.Controls.Add(this.buttonSite);
            this.mainPanel.Controls.Add(this.buttonOyna);
            this.mainPanel.Controls.Add(this.labelVersion);
            this.mainPanel.Controls.Add(this.webBrowser);
            this.mainPanel.Controls.Add(this.pictureBoxSunucuGiris);
            this.mainPanel.Controls.Add(this.pictureBoxSiteDurum);
            this.mainPanel.Controls.Add(this.labelSunucuGiris);
            this.mainPanel.Controls.Add(this.labelSiteDurum);
            this.mainPanel.Controls.Add(this.pictureBoxSunucuDurum);
            this.mainPanel.Controls.Add(this.labelSunucuDurum);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.downloadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.downloadLabel.Location = new System.Drawing.Point(192, 404);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(104, 13);
            this.downloadLabel.TabIndex = 14;
            this.downloadLabel.Text = "Dosyalar indiriliyor..";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.ForeColor = System.Drawing.Color.Green;
            this.progressBar.Location = new System.Drawing.Point(118, 422);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(265, 23);
            this.progressBar.TabIndex = 13;
            // 
            // buttonSite
            // 
            this.buttonSite.BackColor = System.Drawing.Color.Transparent;
            this.buttonSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSite.FlatAppearance.BorderSize = 0;
            this.buttonSite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSite.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonSite.Location = new System.Drawing.Point(449, 412);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(96, 26);
            this.buttonSite.TabIndex = 12;
            this.buttonSite.Text = "Siteye Git";
            this.buttonSite.UseVisualStyleBackColor = false;
            this.buttonSite.Click += new System.EventHandler(this.ButtonSite_Click);
            this.buttonSite.MouseEnter += new System.EventHandler(this.ButtonSite_MouseEnter);
            this.buttonSite.MouseLeave += new System.EventHandler(this.ButtonSite_MouseLeave);
            // 
            // buttonOyna
            // 
            this.buttonOyna.BackColor = System.Drawing.Color.Transparent;
            this.buttonOyna.BackgroundImage = global::EightbornLauncher.Properties.Resources.start1;
            this.buttonOyna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOyna.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.buttonOyna.FlatAppearance.BorderSize = 0;
            this.buttonOyna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOyna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOyna.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOyna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonOyna.Location = new System.Drawing.Point(619, 350);
            this.buttonOyna.Name = "buttonOyna";
            this.buttonOyna.Size = new System.Drawing.Size(129, 59);
            this.buttonOyna.TabIndex = 11;
            this.buttonOyna.UseVisualStyleBackColor = false;
            this.buttonOyna.Click += new System.EventHandler(this.ButtonOyna_Click);
            this.buttonOyna.MouseEnter += new System.EventHandler(this.ButtonOyna_MouseEnter);
            this.buttonOyna.MouseLeave += new System.EventHandler(this.ButtonOyna_MouseLeave);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVersion.Font = new System.Drawing.Font("Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelVersion.Location = new System.Drawing.Point(12, 428);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(30, 11);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "v 1.0.0";
            // 
            // webBrowser
            // 
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(14, 147);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(531, 250);
            this.webBrowser.TabIndex = 7;
            this.webBrowser.Url = new System.Uri("http://eightbornv.site/eightborn-launcher/html/index.html", System.UriKind.Absolute);
            // 
            // pictureBoxSunucuGiris
            // 
            this.pictureBoxSunucuGiris.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSunucuGiris.BackgroundImage = global::EightbornLauncher.Properties.Resources.acik;
            this.pictureBoxSunucuGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSunucuGiris.Location = new System.Drawing.Point(741, 274);
            this.pictureBoxSunucuGiris.Name = "pictureBoxSunucuGiris";
            this.pictureBoxSunucuGiris.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxSunucuGiris.TabIndex = 6;
            this.pictureBoxSunucuGiris.TabStop = false;
            // 
            // pictureBoxSiteDurum
            // 
            this.pictureBoxSiteDurum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSiteDurum.BackgroundImage = global::EightbornLauncher.Properties.Resources.acik;
            this.pictureBoxSiteDurum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSiteDurum.Location = new System.Drawing.Point(741, 194);
            this.pictureBoxSiteDurum.Name = "pictureBoxSiteDurum";
            this.pictureBoxSiteDurum.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxSiteDurum.TabIndex = 5;
            this.pictureBoxSiteDurum.TabStop = false;
            // 
            // labelSunucuGiris
            // 
            this.labelSunucuGiris.AutoSize = true;
            this.labelSunucuGiris.BackColor = System.Drawing.Color.Transparent;
            this.labelSunucuGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSunucuGiris.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSunucuGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelSunucuGiris.Location = new System.Drawing.Point(592, 269);
            this.labelSunucuGiris.Name = "labelSunucuGiris";
            this.labelSunucuGiris.Size = new System.Drawing.Size(116, 19);
            this.labelSunucuGiris.TabIndex = 4;
            this.labelSunucuGiris.Text = "Sunucuya Giriş";
            // 
            // labelSiteDurum
            // 
            this.labelSiteDurum.AutoSize = true;
            this.labelSiteDurum.BackColor = System.Drawing.Color.Transparent;
            this.labelSiteDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSiteDurum.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSiteDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelSiteDurum.Location = new System.Drawing.Point(592, 189);
            this.labelSiteDurum.Name = "labelSiteDurum";
            this.labelSiteDurum.Size = new System.Drawing.Size(97, 19);
            this.labelSiteDurum.TabIndex = 3;
            this.labelSiteDurum.Text = "Site Durumu";
            // 
            // pictureBoxSunucuDurum
            // 
            this.pictureBoxSunucuDurum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSunucuDurum.BackgroundImage = global::EightbornLauncher.Properties.Resources.acik;
            this.pictureBoxSunucuDurum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSunucuDurum.Location = new System.Drawing.Point(741, 234);
            this.pictureBoxSunucuDurum.Name = "pictureBoxSunucuDurum";
            this.pictureBoxSunucuDurum.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxSunucuDurum.TabIndex = 2;
            this.pictureBoxSunucuDurum.TabStop = false;
            // 
            // labelSunucuDurum
            // 
            this.labelSunucuDurum.AutoSize = true;
            this.labelSunucuDurum.BackColor = System.Drawing.Color.Transparent;
            this.labelSunucuDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSunucuDurum.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSunucuDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelSunucuDurum.Location = new System.Drawing.Point(592, 229);
            this.labelSunucuDurum.Name = "labelSunucuDurum";
            this.labelSunucuDurum.Size = new System.Drawing.Size(124, 19);
            this.labelSunucuDurum.TabIndex = 1;
            this.labelSunucuDurum.Text = "Sunucu Durumu";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.pictureBoxLogo);
            this.headerPanel.Controls.Add(this.buttonMinimize);
            this.headerPanel.Controls.Add(this.buttonClose);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 141);
            this.headerPanel.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::EightbornLauncher.Properties.Resources.Baslksz_1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(247, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(340, 90);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = global::EightbornLauncher.Properties.Resources.minimize;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(726, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(24, 24);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.ButtonMinimize_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::EightbornLauncher.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(756, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eightborn Launcher";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunucuGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiteDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunucuDurum)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSunucuDurum;
        private System.Windows.Forms.PictureBox pictureBoxSunucuDurum;
        private System.Windows.Forms.Label labelSiteDurum;
        private System.Windows.Forms.Label labelSunucuGiris;
        private System.Windows.Forms.PictureBox pictureBoxSiteDurum;
        private System.Windows.Forms.PictureBox pictureBoxSunucuGiris;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonOyna;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label downloadLabel;
    }
}

