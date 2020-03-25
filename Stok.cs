using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //gerekli sql kütüphanesi eklendi

namespace Stok_Takip
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        //SqlConnection sql =new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True"); //sql in bağlantı linki yazıldı ve bağlantı oluşturuldu


        private void satın_alma_har_Click(object sender, EventArgs e)
        {

        }

        private void Stok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'muhasebeDataSet13.Urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter1.Fill(this.muhasebeDataSet13.Urunler);
            

        }


        private void satıs_is_Click(object sender, EventArgs e)
        {
            satisislem satis =new satisislem();
            satis.Show();
        }

        private void satın_alma_is_Click(object sender, EventArgs e)
        {
            SatınAlmaIs satın = new SatınAlmaIs();
            satın.Show();
        }

        private void btnDön_Click(object sender, EventArgs e)
        {
            anasayfa dön= new anasayfa();
            dön.Show();
            this.Hide();
        }
    }
}
