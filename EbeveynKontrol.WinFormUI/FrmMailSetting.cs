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
    public partial class FrmMailSetting : Form
    {
        private MailManager _mailManager;
        public FrmMailSetting()
        {
            InitializeComponent();
            _mailManager = new MailManager(new AdoMailDal());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                var mail = _mailManager.FirstMail();
                mail.Adress = txtMail.Text;
                var result = _mailManager.Update(mail);
                if (result)
                {
                    MessageBox.Show("Mail adresiniz başarıyla güncellendi.");
                    txtMail.Clear();
                }
                else
                {
                    MessageBox.Show("Mail adresiniz güncellenemedi.");
                }
            }
            else
            {
                MessageBox.Show("Mail adres alanı boş geçilemez.");
            }
        }
    }
}
