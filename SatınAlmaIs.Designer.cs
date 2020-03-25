namespace Stok_Takip
{
    partial class SatınAlmaIs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatınAlmaIs));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mskTrih = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.nmcMiktar = new System.Windows.Forms.NumericUpDown();
            this.nmcVerTutar = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet12 = new Stok_Takip.MuhasebeDataSet12();
            this.satınAlTableAdapter1 = new Stok_Takip.MuhasebeDataSet12TableAdapters.SatınAlTableAdapter();
            this.btnYnle = new System.Windows.Forms.Button();
            this.btnKayt = new System.Windows.Forms.Button();
            this.txtAlısFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcVerTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarih:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kurum/Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ürün Adı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ürün miktarı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ürün alış fiyatı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Verilicek tutar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Satın Alma İşlemi";
            // 
            // mskTrih
            // 
            this.mskTrih.Location = new System.Drawing.Point(217, 91);
            this.mskTrih.Mask = "00/00/0000";
            this.mskTrih.Name = "mskTrih";
            this.mskTrih.Size = new System.Drawing.Size(120, 29);
            this.mskTrih.TabIndex = 7;
            this.mskTrih.ValidatingType = typeof(System.DateTime);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(217, 141);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 29);
            this.txtAd.TabIndex = 8;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(217, 204);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(120, 29);
            this.txtUrunAd.TabIndex = 9;
            // 
            // nmcMiktar
            // 
            this.nmcMiktar.Location = new System.Drawing.Point(217, 271);
            this.nmcMiktar.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nmcMiktar.Name = "nmcMiktar";
            this.nmcMiktar.Size = new System.Drawing.Size(120, 29);
            this.nmcMiktar.TabIndex = 10;
            // 
            // nmcVerTutar
            // 
            this.nmcVerTutar.Location = new System.Drawing.Point(217, 394);
            this.nmcVerTutar.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nmcVerTutar.Name = "nmcVerTutar";
            this.nmcVerTutar.Size = new System.Drawing.Size(120, 29);
            this.nmcVerTutar.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(372, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 341);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tarih";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SirketAd";
            this.dataGridViewTextBoxColumn2.HeaderText = "SirketAd";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MlzAd";
            this.dataGridViewTextBoxColumn3.HeaderText = "MlzAd";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MlzMiktar";
            this.dataGridViewTextBoxColumn4.HeaderText = "MlzMiktar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MlzAlisFiyati";
            this.dataGridViewTextBoxColumn5.HeaderText = "MlzAlisFiyati";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tutar_Borc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tutar_Borc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SatınAl";
            this.bindingSource1.DataSource = this.muhasebeDataSet12;
            // 
            // muhasebeDataSet12
            // 
            this.muhasebeDataSet12.DataSetName = "MuhasebeDataSet12";
            this.muhasebeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satınAlTableAdapter1
            // 
            this.satınAlTableAdapter1.ClearBeforeFill = true;
            // 
            // btnYnle
            // 
            this.btnYnle.BackColor = System.Drawing.Color.White;
            this.btnYnle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYnle.BackgroundImage")));
            this.btnYnle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYnle.Location = new System.Drawing.Point(841, 439);
            this.btnYnle.Name = "btnYnle";
            this.btnYnle.Size = new System.Drawing.Size(73, 66);
            this.btnYnle.TabIndex = 14;
            this.btnYnle.UseVisualStyleBackColor = false;
            this.btnYnle.Click += new System.EventHandler(this.btnYnle_Click);
            // 
            // btnKayt
            // 
            this.btnKayt.BackColor = System.Drawing.Color.White;
            this.btnKayt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKayt.BackgroundImage")));
            this.btnKayt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKayt.Location = new System.Drawing.Point(949, 439);
            this.btnKayt.Name = "btnKayt";
            this.btnKayt.Size = new System.Drawing.Size(68, 66);
            this.btnKayt.TabIndex = 15;
            this.btnKayt.UseVisualStyleBackColor = false;
            this.btnKayt.Click += new System.EventHandler(this.btnKayt_Click);
            // 
            // txtAlısFiyat
            // 
            this.txtAlısFiyat.Location = new System.Drawing.Point(217, 332);
            this.txtAlısFiyat.Name = "txtAlısFiyat";
            this.txtAlısFiyat.Size = new System.Drawing.Size(120, 29);
            this.txtAlısFiyat.TabIndex = 16;
            this.txtAlısFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlısFiyat_KeyPress);
            // 
            // SatınAlmaIs
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1068, 517);
            this.Controls.Add(this.txtAlısFiyat);
            this.Controls.Add(this.btnKayt);
            this.Controls.Add(this.btnYnle);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nmcVerTutar);
            this.Controls.Add(this.nmcMiktar);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTrih);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SatınAlmaIs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma İşlemleri";
            this.Load += new System.EventHandler(this.SatınAlmaIs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nmcMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcVerTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmcTutar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTrih2;
        private System.Windows.Forms.NumericUpDown nmcMiktar2;
        private System.Windows.Forms.TextBox txtAlısFiyat2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MuhasebeDataSet11 muhasebeDataSet11;
        private System.Windows.Forms.BindingSource satınAlBindingSource;
        private MuhasebeDataSet11TableAdapters.SatınAlTableAdapter satınAlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzAlisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAd2;
        private System.Windows.Forms.TextBox txtUrunAd2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskTrih;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.NumericUpDown nmcMiktar;
        private System.Windows.Forms.NumericUpDown nmcVerTutar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MuhasebeDataSet12 muhasebeDataSet12;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MuhasebeDataSet12TableAdapters.SatınAlTableAdapter satınAlTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnYnle;
        private System.Windows.Forms.Button btnKayt;
        private System.Windows.Forms.TextBox txtAlısFiyat;
    }
}