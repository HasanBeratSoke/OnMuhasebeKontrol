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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {   
            InitializeComponent();
        }
         
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True"); //sql bağlantısını yaptım.
        
         private void Mustri_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();  // sql bağlatısını açtım.
            SqlCommand komut =new SqlCommand("insert into Musteri (MusteriAd,MusteriSoyad,MusteriTelefon,MusteriMail,MusteriAdres)values (@p1,@p2,@p3,@p4,@p5)" , baglanti);
            
            komut.Parameters.AddWithValue("@p1", txtAd.Text);          /* "sqlcommand" nesnesinden komut adlı yeni bir değişken oluşturdum */
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);       /* insert into komutunu kullanarak "museteri" tablosudaki verilerine parametler atatım,
                                                                                    yani MusteriAd sutununu "p1" parametresine eşleştirdim*/
            komut.Parameters.AddWithValue("@p3", mskTel.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtAdres.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi başarılı !");  // try cacht ekleyebilirsin
            this.Hide(); // suanki formu katpattım
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
