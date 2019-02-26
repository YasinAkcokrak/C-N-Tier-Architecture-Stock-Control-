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
    public partial class Urun_Cikis : Form
    {
        public Urun_Cikis()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Urun_Bilgisi().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Musteri_Bilgileri().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sec = "select * from urun_ciktisi";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
        //    label14.Visible = false;

            
        }
        public void musteriOKU()
        {
             
            foreach (cMusteri m in (new cService()).musteriOku())
            {
                comboBox2.Items.Add(m);
            }
        }
        public void UrunBilgiOku()
        {
             
            foreach (cUrunBilgi u in (new cService()).urunoku())
            {
                comboBox1.Items.Add(u);

            }
        }
        public void aracOku()
        {
             
            foreach (cArac c in (new cService()).aracıoku())
            {
                comboBox3.Items.Add(c);
            }
        }

        private void Urun_Cikis_Load(object sender, EventArgs e)
        {
            UrunBilgiOku(); musteriOKU(); aracOku();
        }

        private void Urun_Cikis_Shown(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(adetTxt.Text);
                double b = Convert.ToDouble(birimfiyatTxt.Text);
                tplamfiyatTxt.Text = Convert.ToString(a * b);
                gUrunStok.Text = (Convert.ToInt32(gUrunStok.Text) - Convert.ToInt32(adetTxt.Text)).ToString();

                (new cService()).cikanUrun(((cUrunBilgi)comboBox1.SelectedItem), Convert.ToInt32(adetTxt.Text), Convert.ToDouble(birimfiyatTxt.Text), dateTimePicker1.Value, ((cMusteri)comboBox2.SelectedItem), ((cArac)comboBox3.SelectedItem), Convert.ToDouble(tplamfiyatTxt.Text));
                (new cService()).stokGuncelle((((cUrunBilgi)comboBox1.SelectedItem).UrunId), Convert.ToInt32(gUrunStok.Text));
                MessageBox.Show("Siparişiniz Başarıyla Oluşturulmuştur..."); ciktiSil();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sistemden Kaynaklı Oluşmuştur...");
            }
        }
        public void ciktiSil()
        {
             
            adetTxt.Clear();
            birimfiyatTxt.Clear();
            tplamfiyatTxt.Clear();
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sec = "select * from urun_girdisi";
            MySqlDataAdapter ba = new MySqlDataAdapter(sec, (new cBaglanti()).BaglantiGetir());
            DataTable dt = new DataTable();
            ba.Fill(dt);
            dataGridView1.DataSource = dt;
          //  label14.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList secilenurunOku = (new cService()).secileniOku(((cUrunBilgi)comboBox1.SelectedItem).UrunId);
            foreach (cUrunStok uSo in secilenurunOku)
            {
                gUrunStok.Text = uSo.Adet.ToString();
                gAdeturunTxt.Text = uSo.Adet.ToString();
                gbirimiTxt.Text = uSo.Birim_fiyat.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList musteriOku = (new cService()).secilenMusteriOku(((cMusteri)comboBox2.SelectedItem).MusteriId);
            foreach (cMusteri oMo in musteriOku)
            {
                subenoTxt.Text = oMo.Sube_no;
                musteriadiTxt.Text = oMo.Yonetici_adi;
                subeadiTxt.Text = oMo.Sube_adi;

            }
        }

    }
}
