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

namespace confess
{
    public partial class root : Form
    {
        public root()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "root" && textBox2.Text == "1234")
            {
                root f = new root();
                f.Close();
                Giris g = new Giris();
                g.Show();
                this.Hide();
                 
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yapıldı");
            }

            


        }

        private void root_Load(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void root_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
