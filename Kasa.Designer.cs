namespace Stok_Takip
{
    partial class Kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCariAlınıcak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHamGider = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSatıs = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açık hesaplardan alınıcak para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hammadde giderleri:";
            // 
            // lblCariAlınıcak
            // 
            this.lblCariAlınıcak.AutoSize = true;
            this.lblCariAlınıcak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariAlınıcak.Location = new System.Drawing.Point(260, 74);
            this.lblCariAlınıcak.Name = "lblCariAlınıcak";
            this.lblCariAlınıcak.Size = new System.Drawing.Size(18, 20);
            this.lblCariAlınıcak.TabIndex = 2;
            this.lblCariAlınıcak.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kasa İşlemleri";
            // 
            // lblHamGider
            // 
            this.lblHamGider.AutoSize = true;
            this.lblHamGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHamGider.Location = new System.Drawing.Point(260, 167);
            this.lblHamGider.Name = "lblHamGider";
            this.lblHamGider.Size = new System.Drawing.Size(18, 20);
            this.lblHamGider.TabIndex = 5;
            this.lblHamGider.Text = "0";
            this.lblHamGider.Click += new System.EventHandler(this.lblHamGider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satışlardan gelen para:";
            // 
            // lblSatıs
            // 
            this.lblSatıs.AutoSize = true;
            this.lblSatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatıs.Location = new System.Drawing.Point(260, 120);
            this.lblSatıs.Name = "lblSatıs";
            this.lblSatıs.Size = new System.Drawing.Size(18, 20);
            this.lblSatıs.TabIndex = 7;
            this.lblSatıs.Text = "0";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(394, 203);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(106, 40);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Anasayfaya dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(512, 265);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblSatıs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHamGider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCariAlınıcak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa İşlemleri";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCariAlınıcak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHamGider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSatıs;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}