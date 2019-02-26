using confess.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace confess.DAO
{
    public class cUrun_CiktisiDAO
    {

        public void cikanurun(cUrun_Ciktisi cik)
        {
            (new MySqlCommand("insert into urun_ciktisi(urun_bilgi_id,adet,birim_fiyat,tarih,musteri_id,arac_bilgisi_id,toplam_fiyat) values('" + cik.Urunu.UrunId + "','" + cik.Urun_adet + "','" + cik.Birim_fiyat + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + cik.Musteriyi.MusteriId + "','" + cik.Araci.Arac_Id + "','" + cik.Toplam_fiyat + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }
    }
}
