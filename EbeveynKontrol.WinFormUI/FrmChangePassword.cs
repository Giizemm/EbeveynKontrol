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

namespace EbeveynKontrol.WinFormUI
{
    public partial class FrmChangePassword : Form
    {
        private UserManager _userManager;
        public FrmChangePassword()
        {
            InitializeComponent();
            _userManager = new UserManager(new AdoUserDal());
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            var users = _userManager.GetAll();
            var user = users.FirstOrDefault(x => x.Password == txtoldPassword.Text);
            if (user != null)
            {
                if (txtNewPassword.Text == txtNewPasswordAgain.Text)
                {
                    user.Password = txtNewPassword.Text;
                    var result = _userManager.Update(user);
                    if (result)
                    {
                        MessageBox.Show("Şifre başarıyla güncellendi.");
                        txtoldPassword.Clear();
                        txtNewPassword.Clear();
                        txtNewPasswordAgain.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Şifre güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor.");
                }

            }
            else
            {
                MessageBox.Show("Eski şifre yanlış.");
            }
        }
    }
}
