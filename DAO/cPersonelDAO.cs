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
    public class cPersonelDAO
    {

        public void perKaydet(cPersonel p)
        {
            (new MySqlCommand("insert into personel(per_adi,per_tel,per_adres,bolum_id) values('" + p.Per_adi + "','" + p.Per_tel + "','" + p.Per_adres + "','" + p.Bolumu.Bolum_id + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        }

        public ArrayList personelOku()
        {
            ArrayList a = new ArrayList();
            MySqlDataReader oku = new MySqlCommand("select * from personel", (new cBaglanti().BaglantiGetir())).ExecuteReader();
            while (oku.Read())
            {
                cPersonel p = new cPersonel();
                //MySqlDataReader oku2 = new MySqlCommand("select saha_ismi from bolum_id where id=" + oku.GetInt32(4), (new cBaglanti().BaglantiGetir())).ExecuteReader();
                //while (oku2.Read())
                //{
                //    p.Bolumu.Saha_ismi = oku2[0].ToString();
                //}
                p.Personel_id = oku.GetInt32(0);
                p.Per_adi = oku.GetString(1);
                p.Per_tel = oku.GetString(2);
                p.Per_adres = oku.GetString(3);
                p.Bolumu.Bolum_id = oku.GetInt32(4);
                a.Add(p);
            }
            return a;
        }
    }
}
