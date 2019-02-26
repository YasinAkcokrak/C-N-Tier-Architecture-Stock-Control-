using confess.DOMAIN;
using confess.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using confess.DAO;

namespace confess
{
    public partial class Musteri_Bilgileri : Form
    {
        public Musteri_Bilgileri()
        {
            InitializeComponent();
        }

        private void urun_bilgi_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                (new cService()).musterikaydet(musterisubenoTxt.Text, yoneticiadiTxt.Text, subeadiTxt.Text, subeadresTxt.Text, subetelTxt.Text);
                MessageBox.Show("Müşteri Kaydınız Oluşturulmuştur..."); musteriSil();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Siparişinizde Sistemden Kaynaklı Hata Oluşmuştur\n" + Hata.ToString());
            }

        }
        public void musteriSil()
        {
            musterisubenoTxt.Clear();
            subeadiTxt.Clear();
            yoneticiadiTxt.Clear();
            subeadresTxt.Clear();
            subetelTxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriOKU();
        }
        public void musteriOKU()
        {
             
            foreach (cMusteri m in (new cService()).musteriOku())
            {
                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sec = "select * from musteri";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
           // dataGridView1.Visible = true; label6.Visible = true;
        }
        
    }
}
