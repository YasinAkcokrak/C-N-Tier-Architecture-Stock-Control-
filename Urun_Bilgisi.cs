using confess.DAO;
using confess.DOMAIN;
using confess.Service;
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
    public partial class Urun_Bilgisi : Form
    {
        public Urun_Bilgisi()
        {
            InitializeComponent();
        }

        private void urun_bilgi_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                (new cService()).urunbilgiKaydet(urunSerinoTxt.Text, urunaciklamaTxt.Text, urunadiTxt.Text); UrunBilgiOku(); groupBox2.Enabled = true;
                MessageBox.Show("Yeni Ürün Kaydı Yaptınız Lütfen Stok Girişide Yapınız..."); urunsil();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Kayıt Yapamıyoruz....");
            }
        }
        public void urunsil()
        {
            urunSerinoTxt.Clear();
            urunadiTxt.Clear();
            urunaciklamaTxt.Clear();
        }
        public void UrunBilgiOku()
        {
            comboBox2.Items.Clear();
            foreach (cUrunBilgi u in (new cService()).urunoku())
            {
                comboBox2.Items.Add(u);
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
             
        }

        private void Urun_Bilgisi_Load(object sender, EventArgs e)
        {
            UrunBilgiOku();
            MessageBox.Show("Lütfen Ürün Kaydı Oluşturunuz...");

        }

        private void Urun_Bilgisi_Shown(object sender, EventArgs e)
        {
            urunSerinoTxt.Focus();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            StokOku();
        }
        public void StokOku()
        {
             
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            StokOku();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          //  (new cService()).stokKaydet(((cUrunBilgi)comboBox1.SelectedItem), Convert.ToInt32(adetTxt.Text), Convert.ToDouble(birimfiyatTxt.Text), dateTimePicker1.Value);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sec = "select * from urun_bilgi";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true; label4.Visible = true;
            groupBox2.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                (new cService()).stokKaydet(((cUrunBilgi)comboBox2.SelectedItem), Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox1.Text), dateTimePicker2.Value); stoksil();
                MessageBox.Show("Başarılı Bir Şekilde Stok Kaydı Oluşturuldu...");
               
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Hata Oluştu..." + Hata.ToString());
            }
        }
        public void stoksil()
        {
            comboBox2.Items.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Urun_Girdisi().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Urun_Cikis().ShowDialog();
        }
    }
}
