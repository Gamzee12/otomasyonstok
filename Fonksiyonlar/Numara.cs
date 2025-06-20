using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksiyonlar
{
    internal class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();

        public string StokGrupKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((
                    from s in DB.TBL_STOKGRUPLARIs
                    orderby s.ID descending
                    select s).First().GRUPKODU
                    );
                Numara++;
                string Num = Numara.ToString().PadLeft( 7, '0' );
                return Num;
            }
            catch (Exception)
            {

                return "000000001";
            }
        }


        public string StokKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((
                    from s in DB.TBL_STOKLARs
                    orderby s.ID descending
                    select s).First().STOKKODU
                    );
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {

                return "000000001";
            }
        }


        public string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((
                    from s in DB.TBL_CARILERs
                    orderby s.ID descending
                    select s).First().CARIKODU
                    );
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {

                return "000000001";
            }
        }

        public string KasaKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((
                    from s in DB.TBL_KASALARs
                    orderby s.ID descending
                    select s).First().KASAKODU
                    );
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {

                return "000000001";
            }
        }

    }
}
