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
    public partial class onayla : Form
    {

        public onayla()
        {
            InitializeComponent();
        }

        private void btn_siparisiOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Siparişiniz ONAYLANDI, post makinesine ve mutfağa gönderildi.Afiyet Olsun ;)", "Confirmation", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btn_listedenKaldır_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btn_menuyeDon_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void onayla_Load(object sender, EventArgs e)
        {
            if (anayemekler.gonderilecekveri != null)
            {
                listBox1.Items.Add(anayemekler.gonderilecekveri);
            }
            if (corbalar.gonderilecekveri != null)
            {
                listBox1.Items.Add(corbalar.gonderilecekveri);
            }
            if (icecekler.gonderilecekveri != null)
            {
                listBox1.Items.Add(icecekler.gonderilecekveri);
            }
            if (salatalar.gonderilecekveri != null)
            {
                listBox1.Items.Add(salatalar.gonderilecekveri);
            }
            if (tatlilar.gonderilecekveri != null)
            {
                listBox1.Items.Add(tatlilar.gonderilecekveri);
            }

       }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
