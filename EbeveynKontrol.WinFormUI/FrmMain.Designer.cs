namespace EbeveynKontrol.WinFormUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBanManagement = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.niHideProgram = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMailSetting = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.Location = new System.Drawing.Point(15, 12);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(175, 47);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Raporlar";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnBanManagement
            // 
            this.btnBanManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBanManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBanManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanManagement.Location = new System.Drawing.Point(15, 76);
            this.btnBanManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnBanManagement.Name = "btnBanManagement";
            this.btnBanManagement.Size = new System.Drawing.Size(175, 47);
            this.btnBanManagement.TabIndex = 0;
            this.btnBanManagement.Text = "Yasak Yönetimi";
            this.btnBanManagement.UseVisualStyleBackColor = false;
            this.btnBanManagement.Click += new System.EventHandler(this.BtnBanManagement_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.Location = new System.Drawing.Point(15, 204);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(175, 47);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Şifreyi Değiştir";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(15, 268);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // niHideProgram
            // 
            this.niHideProgram.Icon = ((System.Drawing.Icon)(resources.GetObject("niHideProgram.Icon")));
            this.niHideProgram.Text = "Ebeveyn Takip Kontrol Sistemi";
            this.niHideProgram.Visible = true;
            this.niHideProgram.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NiHideProgram_MouseDoubleClick);
            // 
            // btnMailSetting
            // 
            this.btnMailSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMailSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMailSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMailSetting.Location = new System.Drawing.Point(15, 140);
            this.btnMailSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnMailSetting.Name = "btnMailSetting";
            this.btnMailSetting.Size = new System.Drawing.Size(175, 47);
            this.btnMailSetting.TabIndex = 0;
            this.btnMailSetting.Text = "Mail Ayarı";
            this.btnMailSetting.UseVisualStyleBackColor = false;
            this.btnMailSetting.Click += new System.EventHandler(this.BtnMailSetting_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnMailSetting);
            this.Controls.Add(this.btnBanManagement);
            this.Controls.Add(this.btnReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebeveyn Takip Menü v1.0";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBanManagement;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.NotifyIcon niHideProgram;
        private System.Windows.Forms.Button btnMailSetting;
        private System.Windows.Forms.Timer timer1;
    }
}