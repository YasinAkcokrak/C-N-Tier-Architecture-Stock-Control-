using confess.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace confess.DAO
{
    public class cUrunGirdisiDAO
    {
        public void girUrun(cUrun_Giridisi gir )
        {
            (new MySqlCommand("insert into urun_girdisi(urun_bilgi_id,tedarikci_id,adet,birim_fiyat,tarih,toplam_fiyat) values('" + gir.Urunu.UrunId + "','" + gir.Tedarikci.TedarikId + "','" + gir.Urun_adet + "','" + gir.Birim_fiyat + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + gir.Toplam_fiyat + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }
    }
}
