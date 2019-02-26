using confess.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
 

namespace confess.DAO
{
    public class cUrunBilgiDAO
    {

        public void urunbilgikaydet(cUrunBilgi c)
        {
            (new MySqlCommand("insert into urun_bilgi(seri_no,urun_aciklama,urun_adi) values('" + c.Serino + "','" + c.Urun_aciklama + "','" + c.Urun_adi + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }

        public ArrayList urunOKU()
        {
            ArrayList oku = new ArrayList();
            MySqlDataReader okunan = new MySqlCommand("select * from urun_bilgi", (new cBaglanti().BaglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                cUrunBilgi b = new cUrunBilgi();
                b.UrunId = okunan.GetInt32(0);
                b.Serino = okunan.GetString(1);
                b.Urun_aciklama = okunan.GetString(2);
                b.Urun_adi = okunan.GetString(3);
                oku.Add(b);
            }
            return oku; 
        }
    }
}
