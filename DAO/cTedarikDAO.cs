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
    class cTedarikDAO
    {
        public void tedarekKaydet(cTedarik ted)
        {
            (new MySqlCommand("insert into tedarikci(adi,adres,tel) values('" + ted.Ted_adi + "','" + ted.Ted_adres + "','" + ted.Ted_tel + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }

        public ArrayList tedOku()
        {
            ArrayList oku = new ArrayList();
            MySqlDataReader okunan = new MySqlCommand("select * from tedarikci", (new cBaglanti().BaglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                oku.Add(new cTedarik(Convert.ToInt32(okunan[0].ToString()), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString()));
            }
            return oku;
        }

        ArrayList okunan = new ArrayList();
        public ArrayList tedarikciyeGit(int gTedarikciId)
        {
            MySqlDataReader oku = new MySqlCommand("select * from tedarikci where id=" + gTedarikciId, (new cBaglanti()).BaglantiGetir()).ExecuteReader();
            while (oku.Read())
            {
                cTedarik t = new cTedarik();
                t.Ted_adi = oku.GetString(1);
                t.Ted_adres = oku.GetString(2);
                t.Ted_tel = oku.GetString(3);
                okunan.Add(t);
            }
            return okunan;
        }
    }
}
