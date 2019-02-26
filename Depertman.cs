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
    public partial class Depertman : Form
    {
        public Depertman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                (new cService()).bolumkaydet(sahaismiTxt.Text, goreviTxt.Text, telTxt.Text);
                MessageBox.Show("Başarılı Bir Şekilde Kaydınız Oluşturuldu..."); bolumSil();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Hata Oluştu.." + Hata.ToString());
            }
        }
        public void bolumSil()
        {
            sahaismiTxt.Clear();
            goreviTxt.Clear();
            telTxt.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                (new cService()).personelKaydet(peradiTxt.Text, pergmsTxt.Text, peradresTxt.Text, (cBolum)comboBox1.SelectedItem);
                MessageBox.Show("Başarılı Bir Şekilde Kaydınız Oluşturuldu..."); personelSil();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Hata Oluştu.." + Hata.ToString());
            }
        }
        public void personelSil()
        {
            peradiTxt.Clear();
            pergmsTxt.Clear();
            comboBox1.Items.Clear();
            peradresTxt.Clear();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bolOku();
        }
        public void bolOku()
        {
            comboBox1.Items.Clear();
            foreach (cBolum b in (new cService()).bolumuOku())
            {
                comboBox1.Items.Add(b);
            }
        }

        public void bolumoku()
        {
            ArrayList oku2 = (new cService()).bolumuOku();
            dataGridView1.DataSource = oku2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
             
        }

        public void personelOku()
        {
            ArrayList oku = (new cService()).peroku();
            dataGridView2.DataSource = oku;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                (new cService()).arackaydet(aracmarkaTxt.Text, aracplakaTxt.Text, arackapasiteTxt.Text, aracmodelTxt.Text);
                MessageBox.Show("Başarılı Bir Şekilde Kaydınız Oluşturulmuştur..."); aracsil();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Hata Oluştu.." + Hata.ToString());
            }
        }
        public void aracsil()
        {
            arackapasiteTxt.Clear();
            aracmarkaTxt.Clear();
            aracplakaTxt.Clear();
            aracmodelTxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true; label6.Visible = true; label1.Visible = true;
            aracmarkaTxt.Focus();
           // aracOku(); //label12.Visible = true;
            string sec = "select * from arac_bilgisi";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        public void aracOku()
        {
            ArrayList arac = (new cService()).aracıoku();
            dataGridView3.DataSource = arac;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sec = "select * from personel";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sec = "select * from bolum";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
