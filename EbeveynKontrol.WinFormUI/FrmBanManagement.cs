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
    public partial class FrmBanManagement : Form
    {
        private BanManager _banManager;

        public FrmBanManagement()
        {
            InitializeComponent();
            _banManager = new BanManager(new AdoBanDal());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _banManager.Add(new Ban()
            {
                Name = txtBanText.Text.ToUpper()
            });
            txtBanText.Clear();
            GetBanList();
        }

        private void FrmBanManagement_Load(object sender, EventArgs e)
        {
            GetBanList();
            //lbBanList.DataSource = _bans;
        }

        void GetBanList()
        {
            dgvBanList.DataSource = _banManager.GetAll();
            dgvBanList.Columns[0].Visible = false;
            dgvBanList.Columns[1].HeaderText = "Yasaklanan Kelime";
        }

        private void TxtBanText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBanText.Text))
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBanList.CurrentRow != null)
            {
                int selectedId = (int)dgvBanList.CurrentRow.Cells[0].Value;
                _banManager.Delete(selectedId);
                GetBanList();
                MessageBox.Show("Seçilen yasaklı kelime başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız.");
            }
        }

        
    }
}
