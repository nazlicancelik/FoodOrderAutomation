﻿using System;
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
    public partial class corbalar : Form
    {
        public corbalar()
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
        private void corbalar_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pazılı Mercimek Çorbası...................15₺");
            listBox1.Items.Add("Soğuk Ayran Aşı Çorbası...................25₺");

            pictureBox1.Hide();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.pazi;

            }
            else if(listBox1.SelectedIndex == 1)
            {
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.ayran;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
