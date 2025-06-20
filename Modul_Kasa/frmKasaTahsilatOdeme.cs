using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon.Modul_Kasa
{
    public partial class frmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {

        bool Edit = false;
        int IslemID = -1;
        string IslemTuru = "kasa Tahsilat";
        public frmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            IslemTuru = txtIslemTuru.SelectedIndex.ToString();
        }
    }
}