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
    public partial class Urun_Girdisi : Form
    {
        public Urun_Girdisi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Urun_Bilgisi().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Tedarikci_Bilgileri().ShowDialog();
             
        }

        private void Urun_Girdisi_Load(object sender, EventArgs e)
        {
            TedarikOku();
            UrunBilgiOku();
        }
        public void UrunBilgiOku()
        {
             
            foreach (cUrunBilgi u in (new cService()).urunoku())
            {
                comboBox1.Items.Add(u);
            }
        }

        public void TedarikOku()
        {
             
            foreach (cTedarik t in (new cService()).tedarikOku())
            {
                comboBox2.Items.Add(t);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string sec = "select * from urun_girdisi";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList tedarikciOku = (new cService()).secilenTedarikci(((cTedarik)comboBox2.SelectedItem).TedarikId);
            foreach (cTedarik ted in tedarikciOku)
            {
                tedadiTxt.Text = ted.Ted_adi;
                tedAdresTxt.Text = ted.Ted_adres;
                tedGsmTxt.Text = ted.Ted_tel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(urunadetTxt.Text);
                double b = Convert.ToDouble(urunfiyatTxt.Text);
                tplamFiyatTxt.Text = Convert.ToString(a * b);

                gAdetTxt.Text = (Convert.ToInt32(urunadetTxt.Text) + Convert.ToInt32(gAdetTxt.Text)).ToString();
                (new cService()).girenUrun(((cUrunBilgi)comboBox1.SelectedItem), ((cTedarik)comboBox2.SelectedItem), Convert.ToInt32(urunadetTxt.Text), Convert.ToDouble(urunfiyatTxt.Text), dateTimePicker1.Value, Convert.ToDouble(tplamFiyatTxt.Text));
                (new cService()).stokGuncelle((((cUrunBilgi)comboBox1.SelectedItem).UrunId), Convert.ToInt32(gAdetTxt.Text));
                MessageBox.Show("Depoya Ürün Girişi Başarıyla Gerçekleşti..."); girdiSil();
               
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Hata Oluştu..." + Hata.ToString());
            }

        }
        public void girdiSil()
        {
             
            urunadetTxt.Clear();
            tplamFiyatTxt.Clear();
            urunfiyatTxt.Clear();
        }
        
        private void Urun_Girdisi_Shown(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sec = "select * from urun_girdisi";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList secilenurunOku = (new cService()).secileniOku(((cUrunBilgi)comboBox1.SelectedItem).UrunId);
            foreach (cUrunStok uSo in secilenurunOku)
            {
                gAdetTxt.Text = uSo.Adet.ToString();
                gurunAdetTxt.Text = uSo.Adet.ToString();
                gBirimfiyatTxt.Text = uSo.Birim_fiyat.ToString();
            }
        }
    }
}
