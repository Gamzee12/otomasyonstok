using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static int UserID = -1;
        public static int Aktarma = -1;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void barBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void barBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void barBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnKasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }
    }
}