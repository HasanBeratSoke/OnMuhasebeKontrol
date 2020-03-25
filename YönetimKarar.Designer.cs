namespace Stok_Takip
{
    partial class YönetimKarar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.crtUrun = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crtUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // crtUrun
            // 
            chartArea1.Name = "ChartArea1";
            this.crtUrun.ChartAreas.Add(chartArea1);
            this.crtUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitMinFontSize = 5;
            legend1.IsEquallySpacedItems = true;
            legend1.Name = "Legend1";
            this.crtUrun.Legends.Add(legend1);
            this.crtUrun.Location = new System.Drawing.Point(0, 0);
            this.crtUrun.Name = "crtUrun";
            this.crtUrun.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Urunler";
            series1.YValuesPerPoint = 11;
            this.crtUrun.Series.Add(series1);
            this.crtUrun.Size = new System.Drawing.Size(779, 524);
            this.crtUrun.TabIndex = 0;
            this.crtUrun.Text = "Satış miktar";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "Title1";
            title1.Text = "Stokdaki Ürün Miktarları";
            this.crtUrun.Titles.Add(title1);
            // 
            // YönetimKarar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 524);
            this.Controls.Add(this.crtUrun);
            this.Name = "YönetimKarar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim karar destek";
            this.Load += new System.EventHandler(this.YönetimKarar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtUrun;
    }
}