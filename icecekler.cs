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
    public partial class icecekler : Form
    {
        public icecekler()
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

        private void icecekler_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Coca Cola.........................10₺");
            listBox1.Items.Add("Naneli Limonata....................7₺");
            listBox1.Items.Add("Ayran..............................7₺");

            listBox1.Items.Add("Yasemin Çayı......................15₺");
            listBox1.Items.Add("Earl Grey.........................20₺");
            listBox1.Items.Add("Espresso..........................25₺");
            listBox1.Items.Add("Chai Tea Latte....................25₺");
            listBox1.Items.Add("Sıcak Çikolata....................20₺");

            pictureBox1.Hide();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.cola;

            }
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.nanelimon;


            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.yasemin;


            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.grey;


            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.esp;

            }
            else if (listBox1.SelectedIndex == 5)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.latte;

            }
            else if (listBox1.SelectedIndex == 6)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.cikolata;

            }
        }
    }
}
