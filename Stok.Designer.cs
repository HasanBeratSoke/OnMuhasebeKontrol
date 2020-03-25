namespace Stok_Takip
{
    partial class Stok
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.satıs_is = new System.Windows.Forms.Button();
            this.satın_alma_is = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.muhasebeDataSet = new Stok_Takip.MuhasebeDataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new Stok_Takip.MuhasebeDataSetTableAdapters.UrunlerTableAdapter();
            this.mlzSatisFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlzAlisFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlzMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlzAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlzidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet13 = new Stok_Takip.MuhasebeDataSet13();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.urunlerTableAdapter1 = new Stok_Takip.MuhasebeDataSet13TableAdapters.UrunlerTableAdapter();
            this.btnDön = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet13)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.satıs_is);
            this.groupBox1.Controls.Add(this.satın_alma_is);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // satıs_is
            // 
            this.satıs_is.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.satıs_is.Location = new System.Drawing.Point(150, 46);
            this.satıs_is.Name = "satıs_is";
            this.satıs_is.Size = new System.Drawing.Size(115, 83);
            this.satıs_is.TabIndex = 6;
            this.satıs_is.Text = "Satış işlemi";
            this.satıs_is.UseVisualStyleBackColor = false;
            this.satıs_is.Click += new System.EventHandler(this.satıs_is_Click);
            // 
            // satın_alma_is
            // 
            this.satın_alma_is.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.satın_alma_is.Location = new System.Drawing.Point(16, 46);
            this.satın_alma_is.Name = "satın_alma_is";
            this.satın_alma_is.Size = new System.Drawing.Size(115, 83);
            this.satın_alma_is.TabIndex = 5;
            this.satın_alma_is.Text = "Satın Alma İşlemi";
            this.satın_alma_is.UseVisualStyleBackColor = false;
            this.satın_alma_is.Click += new System.EventHandler(this.satın_alma_is_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok İşlemleri";
            // 
            // muhasebeDataSet
            // 
            this.muhasebeDataSet.DataSetName = "MuhasebeDataSet";
            this.muhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.muhasebeDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // mlzSatisFiyatDataGridViewTextBoxColumn
            // 
            this.mlzSatisFiyatDataGridViewTextBoxColumn.DataPropertyName = "MlzSatisFiyat";
            this.mlzSatisFiyatDataGridViewTextBoxColumn.HeaderText = "MlzSatisFiyat";
            this.mlzSatisFiyatDataGridViewTextBoxColumn.Name = "mlzSatisFiyatDataGridViewTextBoxColumn";
            // 
            // mlzAlisFiyatDataGridViewTextBoxColumn
            // 
            this.mlzAlisFiyatDataGridViewTextBoxColumn.DataPropertyName = "MlzAlisFiyat";
            this.mlzAlisFiyatDataGridViewTextBoxColumn.HeaderText = "MlzAlisFiyat";
            this.mlzAlisFiyatDataGridViewTextBoxColumn.Name = "mlzAlisFiyatDataGridViewTextBoxColumn";
            // 
            // mlzMiktarDataGridViewTextBoxColumn
            // 
            this.mlzMiktarDataGridViewTextBoxColumn.DataPropertyName = "MlzMiktar";
            this.mlzMiktarDataGridViewTextBoxColumn.HeaderText = "MlzMiktar";
            this.mlzMiktarDataGridViewTextBoxColumn.Name = "mlzMiktarDataGridViewTextBoxColumn";
            // 
            // mlzAdDataGridViewTextBoxColumn
            // 
            this.mlzAdDataGridViewTextBoxColumn.DataPropertyName = "MlzAd";
            this.mlzAdDataGridViewTextBoxColumn.HeaderText = "MlzAd";
            this.mlzAdDataGridViewTextBoxColumn.Name = "mlzAdDataGridViewTextBoxColumn";
            // 
            // mlzidDataGridViewTextBoxColumn
            // 
            this.mlzidDataGridViewTextBoxColumn.DataPropertyName = "Mlzid";
            this.mlzidDataGridViewTextBoxColumn.HeaderText = "Mlzid";
            this.mlzidDataGridViewTextBoxColumn.Name = "mlzidDataGridViewTextBoxColumn";
            this.mlzidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mlzidDataGridViewTextBoxColumn,
            this.mlzAdDataGridViewTextBoxColumn,
            this.mlzMiktarDataGridViewTextBoxColumn,
            this.mlzAlisFiyatDataGridViewTextBoxColumn,
            this.mlzSatisFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // urunlerBindingSource1
            // 
            this.urunlerBindingSource1.DataMember = "Urunler";
            this.urunlerBindingSource1.DataSource = this.muhasebeDataSet13;
            // 
            // muhasebeDataSet13
            // 
            this.muhasebeDataSet13.DataSetName = "MuhasebeDataSet13";
            this.muhasebeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(319, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 338);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Anlık Stok";
            // 
            // urunlerTableAdapter1
            // 
            this.urunlerTableAdapter1.ClearBeforeFill = true;
            // 
            // btnDön
            // 
            this.btnDön.BackColor = System.Drawing.Color.White;
            this.btnDön.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDön.Location = new System.Drawing.Point(1037, 412);
            this.btnDön.Name = "btnDön";
            this.btnDön.Size = new System.Drawing.Size(88, 62);
            this.btnDön.TabIndex = 8;
            this.btnDön.Text = "Anasayfaya Dön";
            this.btnDön.UseVisualStyleBackColor = false;
            this.btnDön.Click += new System.EventHandler(this.btnDön_Click);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1143, 486);
            this.Controls.Add(this.btnDön);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet13)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button satıs_is;
        private System.Windows.Forms.Button satın_alma_is;
        private System.Windows.Forms.Label label1;
        private MuhasebeDataSet muhasebeDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private MuhasebeDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzSatisFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzAlisFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlzidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MuhasebeDataSet13 muhasebeDataSet13;
        private System.Windows.Forms.BindingSource urunlerBindingSource1;
        private MuhasebeDataSet13TableAdapters.UrunlerTableAdapter urunlerTableAdapter1;
        private System.Windows.Forms.Button btnDön;
    }
}