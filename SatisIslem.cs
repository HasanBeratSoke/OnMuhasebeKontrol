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
    public partial class satisislem : Form
    {
        public satisislem()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True");

        private void satisislem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'muhasebeDataSet10.Satıs' tablosuna veri yükler. Bunu gerektiğioku[0şe;kilde taşıyabilir, veya kaldırabilirsiniz.
            this.satısTableAdapter3.Fill(this.muhasebeDataSet10.Satıs); 

            /* veritabanından verilerin combobox'a cekilmesi*/

            baglanti.Open();
            SqlCommand komut  = new SqlCommand("Select MusteriAd From Musteri", baglanti); //sql sorgummuzu yazdım
            SqlDataReader oku = komut.ExecuteReader(); 
            while (oku.Read()) 
            {
                cmbAd.Items.Add(oku[0].ToString()); // oku parametlerisin 0.verisini cmbAd öğeler kısmına ekle 

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2=new SqlCommand("Select MusteriSoyad From Musteri", baglanti);
            SqlDataReader okuSoyad = komut2.ExecuteReader();
            while (okuSoyad.Read())
            {
                cmbSoyad.Items.Add(okuSoyad[0].ToString());
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 =new SqlCommand("Select MlzAd From Urunler",baglanti);
            SqlDataReader okuMlzAd = komut3.ExecuteReader();
            while (okuMlzAd.Read())
            {
                cmbUrunAd.Items.Add(okuMlzAd[0].ToString());  
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();  // comboba-boxdaki musteri bilgilerini veri tabanına ekliyorum
            SqlCommand ekle =new SqlCommand("insert into Satıs (Tarih,MusteriAd,MusteriSoyad,MlzAd,MlzMiktar,MlzSatisFiyati,Tutar) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)" ,baglanti);
            ekle.Parameters.AddWithValue("@p1", DateTime.Parse(mskTrih.Text)); //string formatından datetime formatına cevirdim.
            ekle.Parameters.AddWithValue("@p2", cmbAd.Text);
            ekle.Parameters.AddWithValue("@p3", cmbSoyad.Text);
            ekle.Parameters.AddWithValue("@p4", cmbUrunAd.Text);
            ekle.Parameters.AddWithValue("@p5", nmcMiktar.Text);
            ekle.Parameters.AddWithValue("@p6", txtStısFiyat.Text);
            ekle.Parameters.AddWithValue("@p7", nmcTutar.Text);
            
            ekle.ExecuteNonQuery(); // sorgular üzerinde değişiklikleri gerçekleştiriyor.
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi başarılı !");  // try cacht ekleyebilirsin


            // SqlCommand komut =new SqlCommand("SELECT(MusteriAd,MusteriSoyad) from Musteri WHERE Musteriid=1");

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.satısTableAdapter3.Fill(this.muhasebeDataSet10.Satıs);
        }

        private void txtStısFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStısFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=44 && e.KeyChar != 46) //textboxun sadece numara, silme,noktave vigüllere yazılmasına izin verdim.
            {
                e.Handled = true;       // yukardaki 8,44,46 numaralar; nokta virgül backspace nin asci tablosundaki karşılığıdır.
            }
        }
    }
}
