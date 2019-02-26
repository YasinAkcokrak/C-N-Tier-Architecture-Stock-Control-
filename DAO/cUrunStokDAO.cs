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
    public class cUrunStokDAO
    {

        public void stokGit(cUrunStok stok)
        {
            (new MySqlCommand("insert into urun_stok(urun_bilgi_id,adet,birim_fiyat,tarih) values('" + stok.Bilgisi.UrunId + "','" + stok.Adet + "','" + stok.Birim_fiyat + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')", (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();             
        }

        ArrayList urunstok = new ArrayList();
        public ArrayList urunStokGetir(int gSecilenUrunId)
        {
            MySqlDataReader oku = new MySqlCommand("select * from urun_stok where urun_bilgi_id=" + gSecilenUrunId, (new cBaglanti()).BaglantiGetir()).ExecuteReader();
            while (oku.Read())
            {
                cUrunStok uSo = new cUrunStok();
                uSo.Adet = oku.GetInt32(2);
                uSo.Birim_fiyat = oku.GetDouble(3);
                urunstok.Add(uSo);
            }
            return urunstok;
            
          
        }

        public void   guncelle(int gId, int gAdet)
        {
            (new MySqlCommand("update urun_stok set adet=" + gAdet + " where urun_bilgi_id=" + gId, (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();

        }

        //public void stokeksilt(int gId, int gAdet)
        //{
        //    (new MySqlCommand("update urun_stok set adet=" + gAdet + "where urun_bilgi_id" + gId, (new cBaglanti()).BaglantiGetir())).ExecuteNonQuery();
        //}
    }
}
