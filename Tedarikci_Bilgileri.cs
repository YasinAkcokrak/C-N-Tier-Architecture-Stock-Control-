using confess.DAO;
using confess.DOMAIN;
using confess.Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Tedarikci_Bilgileri : Form
    {
        public Tedarikci_Bilgileri()
        {
            InitializeComponent();
        }

        private void urun_bilgi_bttn_Click(object sender, EventArgs e)
        {
            TedarikOku();
            try
            {
                (new cService()).tedkaydet(tedarekadiTxt.Text, tedarekAdresTxt.Text, tedarekgsmTxt.Text);
                MessageBox.Show("Kaydınız Başıyla Oluşturulmuştur..."); tedarikciSil();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Hata Oluştu..." + Hata.ToString());
            }
        }
        public void tedarikciSil()
        {
            tedarekadiTxt.Clear();
            tedarekAdresTxt.Clear();
            tedarekgsmTxt.Clear();
        }

        private void Tedarikci_Bilgileri_Load(object sender, EventArgs e)
        {

        }
        public void TedarikOku()
        {
          
            foreach (cTedarik t in (new cService()).tedarikOku())
            {
               // comboBox2.Items.Add(t);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TedarikOku();
           // tedarikiOku();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sec = "select * from tedarikci";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
          //  dataGridView1.Visible = true; label6.Visible = true;
            //tedarikiOku();
            //dataGridView1.Visible = true; label6.Visible = true;
          
        }
        public void tedarikiOku()
        {
            ArrayList tedarikci = (new cService()).tedarikOku();
            dataGridView1.DataSource = tedarikci;
        }

        private void Tedarikci_Bilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            TedarikOku();
        }
    }
}
