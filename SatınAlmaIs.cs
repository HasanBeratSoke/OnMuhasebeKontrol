using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip
{
    public partial class SatınAlmaIs : Form
    {
        public SatınAlmaIs()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True"); //sql bağlantısı kuruldu.
        
        private void SatınAlmaIs_Load_1(object sender, EventArgs e)
        {


            // TODO: Bu kod satırı 'muhasebeDataSet12.SatınAl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satınAlTableAdapter1.Fill(this.muhasebeDataSet12.SatınAl);
        }


        private void btnKayt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sat=new SqlCommand("insert into SatınAl (Tarih,SirketAd,MlzAd,MlzMiktar,MlzAlisFiyati,Tutar_Borc) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);

            sat.Parameters.AddWithValue("@p1", DateTime.Parse(mskTrih.Text));
            sat.Parameters.AddWithValue("@p2", txtAd.Text);
            sat.Parameters.AddWithValue("@p3", txtUrunAd.Text);
            sat.Parameters.AddWithValue("@p4", nmcMiktar.Text);
            sat.Parameters.AddWithValue("@p5", txtAlısFiyat.Text);
            sat.Parameters.AddWithValue("@p6", nmcVerTutar.Text);

            sat.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydedildi !");
        }

        private void btnYnle_Click(object sender, EventArgs e)
        {
            this.satınAlTableAdapter1.Fill(this.muhasebeDataSet12.SatınAl);
        }

        private void txtAlısFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46) //textboxun sadece numara, silme,noktave vigüllere yazılmasına izin verdim.
            {
                e.Handled = true;       // yukardaki 8,44,46 numaralar; nokta virgül backspace nin asci tablosundaki karşılığıdır.
            }
        }

       
    }
}
