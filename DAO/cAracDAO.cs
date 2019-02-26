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
    public class cAracDAO
    {
        public void aracıKaydet(cArac a)
        {
            (new MySqlCommand("insert into arac_bilgisi(arac_marka,arac_plaka,arac_kapasite,arac_model) values('" + a.Arac_marka + "','" + a.Arac_plaka + "','" + a.Arac_kapasite + "','" + a.Arac_model + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }

        public ArrayList arac()
        {
            ArrayList arac = new ArrayList();
            MySqlDataReader oku = new MySqlCommand("select * from arac_bilgisi", (new cBaglanti()).BaglantiGetir()).ExecuteReader();
            while (oku.Read())
            {
                arac.Add(new cArac(Convert.ToInt32(oku[0]), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString()));
            }
            return arac;
        }
    }
}
