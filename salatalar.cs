using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_restaurant
{
    public partial class salatalar : Form
    {
        public salatalar()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;

        private void btn_menuyeDon_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            this.Hide();
            menu1.Show();
        }
        private void btn_sepeteEkle_Click(object sender, EventArgs e)
        {
            gonderilecekveri = listBox1.SelectedItem.ToString();
        }

        private void salatalar_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bahçe Salatası............................15₺");
            listBox1.Items.Add("Izgara Enginar Salatası...................20₺");
            listBox1.Items.Add("Deniz Ürünleri Salatası...................15₺");
            listBox1.Items.Add("Sezar Salata..............................10₺");

            pictureBox1.Hide();
        }

        

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.bahce;

            }
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.enginar;


            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.deniz;


            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.sezar;


            }
        }
    }
}
