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
    public partial class YönetimKarar : Form
    {
        public YönetimKarar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True");
        private void YönetimKarar_Load(object sender, EventArgs e)

        {
            /* databaseden pie grafine verilerin cekilmesi*/

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select MlzAd,MlzMiktar From Urunler", baglanti); //sql sorgusunu yazdım. urunler tablosundaki Mlzmiktar sütünunu sectim.
            SqlDataReader oku = komut.ExecuteReader(); // komuttan gelen sorguları oku.
            while (oku.Read()) // okuma süresici bitene kadar devam etsin.
            {
                crtUrun.Series["Urunler"].Points.AddXY(oku[0].ToString(), oku[1].ToString()); 
            }
            baglanti.Close();


        }
    }
}
