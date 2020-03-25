using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Cari_Hesap : Form
    {
        public Cari_Hesap()
        {
            InitializeComponent();
        }

        private void Cari_Hesap_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'muhasebeDataSet4.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.muhasebeDataSet4.Musteri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle ekle=new MusteriEkle(); /*müsteri ekleme formuyla bağlantı kurdum*/
            ekle.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.musteriTableAdapter.Fill(this.muhasebeDataSet4.Musteri); // veri listesi yenilensin.
        }

        private void btnDön_Click(object sender, EventArgs e)
        {
            anasayfa dön =new anasayfa();
            dön.Show();
            this.Hide();
            
        }
    }
}
