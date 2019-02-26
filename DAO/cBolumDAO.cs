using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using confess.DOMAIN;
using System.Collections;


namespace confess.DAO
{
    public class cBolumDAO
    {

        public void bolumuKaydet(cBolum b)
        {
            (new MySqlCommand("insert into bolum(saha_ismi,islevi,depertman_tel) values('" + b.Saha_ismi + "','" + b.Islevi + "','" + b.Depertman_tel + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }

        public ArrayList bolOku()
        {
            ArrayList a = new ArrayList();
            MySqlDataReader oku = new MySqlCommand("select * from bolum", (new cBaglanti()).BaglantiGetir()).ExecuteReader();
            while (oku.Read())
            {
                a.Add(new cBolum(Convert.ToInt32(oku[0]), oku[1].ToString(), oku[2].ToString(), oku[3].ToString()));
            }
            return a;
        }
    }
}
