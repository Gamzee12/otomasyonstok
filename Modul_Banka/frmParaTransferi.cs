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

namespace otomasyon.Modul_Banka
{
    public partial class frmParaTransferi : DevExpress.XtraEditors.XtraForm
    {

        string IslemTuru = "Banka Havale";

        public frmParaTransferi()
        {
            InitializeComponent();
        }

        private void txtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtTransferTuru.SelectedIndex == 0)
            {
                rbtnGelen.Text = "Gelen Havale";
                rbtnGiden.Text = "Giden Havale";
                IslemTuru = "Banka Havale";
            }
            else if(txtTransferTuru.SelectedIndex == 1)
            {
                rbtnGelen.Text = "Gelen EFT";
                rbtnGiden.Text = "Giden EFT";
                IslemTuru = "Banka EFT";
            }
        }

        private void frmParaTransferi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}