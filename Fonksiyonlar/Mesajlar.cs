using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksiyonlar
{
    internal class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Kalıcı Olarak Güncellenecektir\n Güncelleme İşlemini Onaylıyor Musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Olan kayıt Kalıcı Olarak Silinecektir\n Silme İşlemini Onaylıyor Musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Ooops, Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
