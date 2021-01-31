using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EbeveynKontrol.Bll.Concrete;
using EbeveynKontrol.Dal.Concrete.AdoNet;
using EbeveynKontrol.Entity;
using EbeveynKontrol.WinFormUI.Tools;

namespace EbeveynKontrol.WinFormUI
{
    public partial class FrmMain : Form
    {
        private BanManager _banManager;
        private MailManager _mailManager;
        private List<Ban> _bans;
        private ReportManager _reportManager;

        public FrmMain()
        {
            InitializeComponent();
            _banManager = new BanManager(new AdoBanDal());
            _mailManager=new MailManager(new AdoMailDal());
            _reportManager=new ReportManager(new AdoReportDal());

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            niHideProgram.Visible = true;
            Hide();

        }

        private void NiHideProgram_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.OpenForms["FrmLogin"].Show();
            niHideProgram.Visible = false;

        }

        private void BtnMailSetting_Click(object sender, EventArgs e)
        {
            FrmMailSetting frmMailSetting = new FrmMailSetting();
            frmMailSetting.ShowDialog();
        }

        private void BtnBanManagement_Click(object sender, EventArgs e)
        {
            FrmBanManagement frmBanManagement = new FrmBanManagement();
            frmBanManagement.ShowDialog();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.ShowDialog();
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _bans = _banManager.GetAll();
        }

        string prev = " ";
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            

            Process[] p = Process.GetProcesses();
            foreach (Process item in p)
            {
                if (item.MainWindowTitle != "" && !item.MainWindowTitle.ToLower().Replace(' ','.').Contains(prev.ToLower()))
                {
                    foreach (var ban in _bans)
                    {
                        if (item.MainWindowTitle.ToLower().Contains(ban.Name.ToLower()))
                        {
                            string mailAdress = _mailManager.FirstMail().Adress;
                            MailTool.Send(mailAdress, item.MainWindowTitle);
                            _reportManager.Add(new Report()
                            {
                                DateTime = DateTime.Now,
                                SiteTitle = item.MainWindowTitle,
                                BanID = ban.Id

                            });
                            prev = ban.Name;
                            item.Kill();
                        }
                    }

                }
            }
        }
    }
}
