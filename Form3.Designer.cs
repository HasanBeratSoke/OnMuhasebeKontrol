namespace Stok_Takip
{
    partial class Cari_Hesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cari_Hesap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet4 = new Stok_Takip.MuhasebeDataSet4();
            this.musteriTableAdapter = new Stok_Takip.MuhasebeDataSet4TableAdapters.MusteriTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnDön = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.musteriTelefonDataGridViewTextBoxColumn,
            this.musteriMailDataGridViewTextBoxColumn,
            this.musteriAdresDataGridViewTextBoxColumn,
            this.musteriBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "Musteriid";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "Musteriid";
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            // 
            // musteriTelefonDataGridViewTextBoxColumn
            // 
            this.musteriTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.HeaderText = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.Name = "musteriTelefonDataGridViewTextBoxColumn";
            // 
            // musteriMailDataGridViewTextBoxColumn
            // 
            this.musteriMailDataGridViewTextBoxColumn.DataPropertyName = "MusteriMail";
            this.musteriMailDataGridViewTextBoxColumn.HeaderText = "MusteriMail";
            this.musteriMailDataGridViewTextBoxColumn.Name = "musteriMailDataGridViewTextBoxColumn";
            // 
            // musteriAdresDataGridViewTextBoxColumn
            // 
            this.musteriAdresDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.HeaderText = "MusteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.Name = "musteriAdresDataGridViewTextBoxColumn";
            // 
            // musteriBorcDataGridViewTextBoxColumn
            // 
            this.musteriBorcDataGridViewTextBoxColumn.DataPropertyName = "MusteriBorc";
            this.musteriBorcDataGridViewTextBoxColumn.HeaderText = "MusteriBorc";
            this.musteriBorcDataGridViewTextBoxColumn.Name = "musteriBorcDataGridViewTextBoxColumn";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.muhasebeDataSet4;
            // 
            // muhasebeDataSet4
            // 
            this.muhasebeDataSet4.DataSetName = "MuhasebeDataSet4";
            this.muhasebeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari hesap işlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(529, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 62);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.BackgroundImage")));
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYenile.Location = new System.Drawing.Point(599, 388);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(67, 62);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDön
            // 
            this.btnDön.BackColor = System.Drawing.Color.White;
            this.btnDön.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDön.Location = new System.Drawing.Point(672, 389);
            this.btnDön.Name = "btnDön";
            this.btnDön.Size = new System.Drawing.Size(88, 62);
            this.btnDön.TabIndex = 4;
            this.btnDön.Text = "Anasayfaya Dön";
            this.btnDön.UseVisualStyleBackColor = false;
            this.btnDön.Click += new System.EventHandler(this.btnDön_Click);
            // 
            // Cari_Hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnDön);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Cari_Hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari hesap İşlemleri";
            this.Load += new System.EventHandler(this.Cari_Hesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MuhasebeDataSet4 muhasebeDataSet4;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private MuhasebeDataSet4TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnDön;
    }
}