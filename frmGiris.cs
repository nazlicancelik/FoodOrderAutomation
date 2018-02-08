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
    public partial class frmYetkiliGiris : Form
    {
        private string username;
        private string password;

        public frmYetkiliGiris()
        {
            InitializeComponent();
        }

        private void frmYetkiliGiris_Load(object sender, EventArgs e)
        {
            txtbox_sifre.PasswordChar = '*';
        }

       
        private void txtbox_kullanıcı_TextChanged(object sender, EventArgs e)
        {
            username = txtbox_kullanıcı.Text;
        }

        private void txtbox_sifre_TextChanged(object sender, EventArgs e)
        {
            password = txtbox_sifre.Text;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (username == "nazli" && password == "12345")
            {
                Menu menu_form = new Menu();
                menu_form.Show();
                this.Hide();

            }
            else
            {
                label2.Text = "Yanlış Giriş Yaptınız.Tekrar Deneyiniz.";

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
