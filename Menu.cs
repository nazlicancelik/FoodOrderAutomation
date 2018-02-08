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
    public partial class Menu : Form
    {
        static

        onayla onay = new onayla();
        anayemekler ana = new anayemekler();
        salatalar salata = new salatalar();
        corbalar corba = new corbalar();
        icecekler icecek = new icecekler();
        tatlilar tatli = new tatlilar();


        public Menu()
        {
            InitializeComponent();
        }

        private void btn_tatlılar_Click(object sender, EventArgs e)
        {
            tatli.Show();
            this.Hide();
        }

        private void btn_anayemekler_Click(object sender, EventArgs e)
        {
            ana.Show();
            this.Hide();

        }

        private void btn_salatalar_Click(object sender, EventArgs e)
        {
            salata.Show();
            this.Hide();
        }

        private void btn_corbalar_Click(object sender, EventArgs e)
        {
            corba.Show();
            this.Hide();
        }

        private void btn_icecek_Click(object sender, EventArgs e)
        {
            icecek.Show();
            this.Hide();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            onay.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
