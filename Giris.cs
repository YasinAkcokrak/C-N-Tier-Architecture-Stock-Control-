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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
       
        private void Giris_Load(object sender, EventArgs e)
        {
             
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Urun_Bilgisi().ShowDialog();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Lütfen Ürün Ekleyiniz...", "Deneme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult cevap;
            cevap = MessageBox.Show("Lütfen Ürün Kaydı Yapınız !!!", "İKAZ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cevap == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Ürün Formuna Gidiyorsunuz ...");
                new Urun_Bilgisi().ShowDialog();
                new Urun_Girdisi().ShowDialog();
            }
            else if (cevap == System.Windows.Forms.DialogResult.Cancel)
            {
                MessageBox.Show("Çıkış Yaptınız...");
            }
            else if (cevap == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Ürün Eklemeden Devam Ediyorsunuz !!!! ");
                new Urun_Girdisi().ShowDialog();
            }



             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Urun_Cikis().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Depertman().ShowDialog(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Depo_Stok().ShowDialog();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new Musteri_Bilgileri().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Tedarikci_Bilgileri().ShowDialog();
        }
    }
}
