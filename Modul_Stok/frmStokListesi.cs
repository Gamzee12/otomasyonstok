using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon.Modul_Stok
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public frmStokListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            try
            {
                var lst = from s in DB.TBL_STOKLARs
                          where s.STOKADI.Contains(txtStokAdi.Text) && s.STOKBARKOD.Contains(txtBarkod.Text) && s.STOKKODU.Contains(txtStokKodu.Text)
                          select s;
                    Liste.DataSource = lst;
            }
            catch (Exception)
            {

                MessageBox.Show("Eyvah, Sistemsel Kaynaklı Hataya Rastlanıldı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
                txtBarkod.Text = "";
                txtStokAdi.Text = "";
                txtStokKodu.Text = "";
                MessageBox.Show("Stok Listesi Formu Temizlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
                Listele();
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {

                SecimID = -1;
                MessageBox.Show("Eyvah, Sistemsel Kaynaklı Hata Meydana Geldi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}