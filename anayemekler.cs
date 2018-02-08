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
    public partial class anayemekler : Form
    {
        public anayemekler()
        {
            InitializeComponent();
        }

        public static string gonderilecekveri;

        private void btn_menuyeDon_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void anayemekler_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bonfile Dilimleri ...................30₺");
            listBox1.Items.Add("Izgara Antrikot......................35₺");
            listBox1.Items.Add("Izgara Dana Bonfile..................35₺");
            listBox1.Items.Add("New York Steak.......................25₺");
            listBox1.Items.Add("Cız-Bız Steak........................25₺");
           
            pictureBox1.Hide();

        }
        private void btn_sepeteEkle_Click(object sender, EventArgs e)
        {
            gonderilecekveri = listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.bonfile; 

            }
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.antrikot;


            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox1.Show();
                pictureBox1.Image =Properties.Resources.dana_bonfile;


            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.steak;


            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.cızbız;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
