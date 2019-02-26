using confess.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace confess
{
    public partial class Depo_Stok : Form
    {
        public Depo_Stok()
        {
            InitializeComponent();
        }

        private void Depo_Stok_Load(object sender, EventArgs e)
        {
            string sec = "select * from urun_stok";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
