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
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {

        bool Edit = false;
        int SecimID = -1;

        public frmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {

        }
    }
}