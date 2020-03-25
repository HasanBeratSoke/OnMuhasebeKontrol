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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }

        SqlConnection baglantı= new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True");

        private void Kasa_Load(object sender, EventArgs e)
        {
            /* veritabanındaki musteri borçların toplanması ve label alanına yazdırılması*/

            baglantı.Open();
            SqlCommand komut=new SqlCommand("Select Sum(MusteriBorc) from Musteri", baglantı); //sql sorgu kumutunu yazdım, sum komutu ile tutar kısmındaki verileri topladım.
            SqlDataReader oku = komut.ExecuteReader(); // verilerin okunması için, oku adlı değişken ouşturdum 
            while (oku.Read())
            {
                lblCariAlınıcak.Text = oku[0].ToString() + "TL" ;  //okudan gelen verileri label alanına atadım.
            }
            baglantı.Close();

            /*  satışlardan gelen gelirlerin label a atanması*/

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select Sum(Tutar) from Satıs", baglantı);
            SqlDataReader tutarOku = komut2.ExecuteReader();
            while (tutarOku.Read())
            {
                lblSatıs.Text = tutarOku[0].ToString() + "TL"; 
            }
            baglantı.Close();

            /*Hammadeden giderlerin label a cekilmesi*/

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select Sum(Tutar_Borc) from SatınAl", baglantı);
            SqlDataReader giderOku = komut3.ExecuteReader();
            while (giderOku.Read())
            {
                lblHamGider.Text = giderOku[0].ToString() + "TL";
            }
            baglantı.Close();


        }

        private void lblHamGider_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide(); //arkaplanda anasayfa acık olduğuğu için sadece kasa sayfasını kapattım.
        }
    }
}
