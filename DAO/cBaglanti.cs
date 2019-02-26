using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace confess.DAO
{
    public class cBaglanti
    {
        public MySqlConnection BaglantiGetir()
        {
           // MySqlConnection bag = new MySqlConnection("server=172.21.54.3; user Id=yasinakcokrak123; password=akcokrakdb; database=akcokrakdb");
            MySqlConnection bag = new MySqlConnection("server=172.21.54.3; user Id=yasinakcokrak; password=akcokrak123; database=akcokrakdb");
            bag.Open();
            return bag;
        }
    }
}
