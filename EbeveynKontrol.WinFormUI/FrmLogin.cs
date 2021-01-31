using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EbeveynKontrol.Bll.Concrete;
using EbeveynKontrol.Dal.Concrete.AdoNet;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.WinFormUI
{
    public partial class FrmLogin : Form
    {
        private UserManager _userManager;
        public FrmLogin()
        {
            InitializeComponent();
            _userManager = new UserManager(new AdoUserDal());
        }

        private FrmMain frmMain;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) &&string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez.");
            else
            {

                User user = new User() { Name = txtUser.Text, Password = txtPassword.Text };

                if (_userManager.Login(user))
                {
                    MessageBox.Show("Giriş başarılı");

                    if (frmMain == null)
                    {
                        frmMain = new FrmMain();
                        frmMain.Show();
                    }
                    else
                    {
                        Application.OpenForms["FrmMain"].Show();
                    }
                    txtUser.Clear();
                    txtPassword.Clear();
                    this.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Giriş başarısız. Kullanıcı adı veya şifre yanlış.");
                }
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (frmMain != null)
            {
                e.Cancel = true;
                frmMain.niHideProgram.Visible = true;
                //Hide();
            }
        }

       
    }
}
