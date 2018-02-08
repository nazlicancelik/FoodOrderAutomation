namespace new_restaurant
{
    partial class onayla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onayla));
            this.btn_listedenKaldır = new System.Windows.Forms.Button();
            this.btn_siparisiOnayla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_menuyeDon = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listedenKaldır
            // 
            this.btn_listedenKaldır.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_listedenKaldır.BackgroundImage")));
            this.btn_listedenKaldır.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_listedenKaldır.Location = new System.Drawing.Point(540, 476);
            this.btn_listedenKaldır.Margin = new System.Windows.Forms.Padding(4);
            this.btn_listedenKaldır.Name = "btn_listedenKaldır";
            this.btn_listedenKaldır.Size = new System.Drawing.Size(95, 69);
            this.btn_listedenKaldır.TabIndex = 10;
            this.btn_listedenKaldır.UseVisualStyleBackColor = true;
            this.btn_listedenKaldır.Click += new System.EventHandler(this.btn_listedenKaldır_Click);
            // 
            // btn_siparisiOnayla
            // 
            this.btn_siparisiOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siparisiOnayla.BackgroundImage")));
            this.btn_siparisiOnayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_siparisiOnayla.Location = new System.Drawing.Point(640, 476);
            this.btn_siparisiOnayla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_siparisiOnayla.Name = "btn_siparisiOnayla";
            this.btn_siparisiOnayla.Size = new System.Drawing.Size(94, 69);
            this.btn_siparisiOnayla.TabIndex = 9;
            this.btn_siparisiOnayla.UseVisualStyleBackColor = true;
            this.btn_siparisiOnayla.Click += new System.EventHandler(this.btn_siparisiOnayla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SİPARİŞLER";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(280, 151);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 260);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_menuyeDon
            // 
            this.btn_menuyeDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menuyeDon.BackgroundImage")));
            this.btn_menuyeDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menuyeDon.Location = new System.Drawing.Point(449, 476);
            this.btn_menuyeDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menuyeDon.Name = "btn_menuyeDon";
            this.btn_menuyeDon.Size = new System.Drawing.Size(89, 69);
            this.btn_menuyeDon.TabIndex = 11;
            this.btn_menuyeDon.UseVisualStyleBackColor = true;
            this.btn_menuyeDon.Click += new System.EventHandler(this.btn_menuyeDon_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCıkıs.BackgroundImage")));
            this.btnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCıkıs.Location = new System.Drawing.Point(696, 0);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(51, 54);
            this.btnCıkıs.TabIndex = 14;
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // onayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 558);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btn_menuyeDon);
            this.Controls.Add(this.btn_listedenKaldır);
            this.Controls.Add(this.btn_siparisiOnayla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "onayla";
            this.Text = "onayla";
            this.Load += new System.EventHandler(this.onayla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_listedenKaldır;
        private System.Windows.Forms.Button btn_siparisiOnayla;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_menuyeDon;
        private System.Windows.Forms.Button btnCıkıs;
    }
}