using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksiyonlar
{
    internal class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool Secim = false)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public int StokGruplari(bool Secim = false)
        {
            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {

        }

        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.frmStokKarti frm = new Modul_Stok .frmStokKarti();

            frm.ShowDialog();
        }

        #endregion


        #region CARI FORMLARI
        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.frmCariGruplari frm = new Modul_Cari.frmCariGruplari();
            if(Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();
            if(Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
                return AnaForm.Aktarma;
        }

        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modul_Cari.frmCariAcilisKarti frm = new Modul_Cari.frmCariAcilisKarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();
        }

        #endregion

        public void KasaAcilisKarti()
        {
            Modul_Kasa.frmKasaAcilisKarti frm = new Modul_Kasa.frmKasaAcilisKarti ();
            frm.ShowDialog();
        }
    }
}
