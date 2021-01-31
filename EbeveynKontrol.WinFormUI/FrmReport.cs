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
    public partial class FrmReport : Form
    {
        private readonly ReportManager _reportManager;
        public FrmReport()
        {
            InitializeComponent();
            _reportManager = new ReportManager(new AdoReportDal());
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            GetReportList();
        }
        void GetReportList()
        {
            dgvReport.DataSource = _reportManager.GetAll();
            dgvReport.Columns[0].Visible = false;
            dgvReport.Columns[3].Visible = false;
            dgvReport.Columns[4].Visible = false;
            dgvReport.Columns[1].HeaderText = "Girilen Site Adı";
            dgvReport.Columns[2].HeaderText = "Giriş Yapılan Tarih-Saat";

        }

        private void BtnReportDelete_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int selectedId = (int)dgvReport.CurrentRow.Cells[0].Value;
                _reportManager.Delete(selectedId);
                GetReportList();
                MessageBox.Show("Seçilen kayıt başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız.");
            }
        }
    }
}
