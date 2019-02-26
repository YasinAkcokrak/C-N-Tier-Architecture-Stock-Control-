using confess.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;

namespace confess.DAO
{
    public class cMusteriDAO
    {

        public void musteriyiKaydet(cMusteri m)
        {
            (new MySqlCommand("insert into musteri(sube_no,yonetici_adi,sube_adi,adres,tel) values('" + m.Sube_no + "','" + m.Yonetici_adi + "','" + m.Sube_adi + "','" + m.Adres + "','" + m.Tel + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }

        public ArrayList mustOku()
        {
            ArrayList a = new ArrayList();
            MySqlDataReader oku = new MySqlCommand("select * from musteri", (new cBaglanti()).BaglantiGetir()).ExecuteReader();
            while (oku.Read())
            {
                a.Add(new cMusteri(Convert.ToInt32(oku[0]), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString()));
            }
            return a;
        }

        ArrayList okunan = new ArrayList();
        public ArrayList secilenMusteriyiGetir(int gMusteriId)
        {
            MySqlDataReader oku = new MySqlCommand("select * from musteri where id=" + gMusteriId, (new cBaglanti()).BaglantiGetir()).ExecuteReader();
            while (oku.Read())
            {
                cMusteri must = new cMusteri();
                must.Sube_no = oku.GetString(1);
                must.Yonetici_adi = oku.GetString(2);
                must.Sube_adi = oku.GetString(3);
                okunan.Add(must);
            }
            return okunan;
        }
    }
}
