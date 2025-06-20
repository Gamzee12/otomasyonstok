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
    public partial class frmKasaListesi : DevExpress.XtraEditors.XtraForm
    {

        public bool Secim = false;

        public frmKasaListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {

        }

        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}