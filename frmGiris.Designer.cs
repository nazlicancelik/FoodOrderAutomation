namespace new_restaurant
{
    partial class frmYetkiliGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkiliGiris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_kullanıcı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiris.Location = new System.Drawing.Point(204, 523);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(222, 51);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Location = new System.Drawing.Point(204, 482);
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(222, 22);
            this.txtbox_sifre.TabIndex = 2;
            this.txtbox_sifre.TextChanged += new System.EventHandler(this.txtbox_sifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harrington", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yetkili Girişi";
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCıkıs.BackgroundImage")));
            this.btnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCıkıs.Location = new System.Drawing.Point(541, 2);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(48, 37);
            this.btnCıkıs.TabIndex = 4;
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(201, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_kullanıcı
            // 
            this.txtbox_kullanıcı.Location = new System.Drawing.Point(204, 454);
            this.txtbox_kullanıcı.Name = "txtbox_kullanıcı";
            this.txtbox_kullanıcı.Size = new System.Drawing.Size(222, 22);
            this.txtbox_kullanıcı.TabIndex = 6;
            this.txtbox_kullanıcı.TextChanged += new System.EventHandler(this.txtbox_kullanıcı_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Harrington", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanıcı Adı  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Harrington", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre              :";
            // 
            // frmYetkiliGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_kullanıcı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.btnGiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYetkiliGiris";
            this.Text = "Can Cafe Yetkili Giriş";
            this.Load += new System.EventHandler(this.frmYetkiliGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_kullanıcı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

