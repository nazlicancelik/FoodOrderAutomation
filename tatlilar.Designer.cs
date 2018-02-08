namespace new_restaurant
{
    partial class tatlilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tatlilar));
            this.btn_sepeteEkle = new System.Windows.Forms.Button();
            this.btn_menuyeDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sepeteEkle
            // 
            this.btn_sepeteEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sepeteEkle.BackgroundImage")));
            this.btn_sepeteEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sepeteEkle.Location = new System.Drawing.Point(421, 477);
            this.btn_sepeteEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sepeteEkle.Name = "btn_sepeteEkle";
            this.btn_sepeteEkle.Size = new System.Drawing.Size(81, 74);
            this.btn_sepeteEkle.TabIndex = 17;
            this.btn_sepeteEkle.UseVisualStyleBackColor = true;
            this.btn_sepeteEkle.Click += new System.EventHandler(this.btn_sepeteEkle_Click);
            // 
            // btn_menuyeDon
            // 
            this.btn_menuyeDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menuyeDon.BackgroundImage")));
            this.btn_menuyeDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menuyeDon.Location = new System.Drawing.Point(166, 477);
            this.btn_menuyeDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menuyeDon.Name = "btn_menuyeDon";
            this.btn_menuyeDon.Size = new System.Drawing.Size(72, 74);
            this.btn_menuyeDon.TabIndex = 16;
            this.btn_menuyeDon.UseVisualStyleBackColor = true;
            this.btn_menuyeDon.Click += new System.EventHandler(this.btn_menuyeDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::new_restaurant.Properties.Resources.sufle;
            this.pictureBox1.Location = new System.Drawing.Point(166, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(166, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 180);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "TATLILAR";
            // 
            // tatlilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sepeteEkle);
            this.Controls.Add(this.btn_menuyeDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tatlilar";
            this.Text = "tatlilar";
            this.Load += new System.EventHandler(this.tatlilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sepeteEkle;
        private System.Windows.Forms.Button btn_menuyeDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}