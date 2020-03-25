/*****************************************************************************************************************************************
 *                                    SAKARYA ÜNİVERSİTESİ
 *                               BİLGİSAYAR VE BİLİŞİM FAKÜLTESİ
 *                               BİLİŞİM SİSTEMLERİ MÜHENDİSLERİ
 *                              NESNEYE DAYALI PROGLAMLAMA DERSİ
 *                                 2019-2020 BAHAR DÖNEMİ
 *                              ÖDEV NUMARASI.............: 2019-2020 BAHAR DÖNEMİ İLK ÖDEVİ
 *                              ÖĞRENİNİN ADI/SOYADI......: HASAN BERAT SÖKE
 *                              ÖĞRENİNİN NUMARASI........: B181200046
 *                              
 *
 * ***************************************************************************************************************************************
 */



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
    public partial class KullanıcıGrs : Form
    {
        public KullanıcıGrs()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=Muhasebe;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanıcıadi, şifre;// değişkenler oluşturuldu
            kullanıcıadi = this.txtKullanıcı.Text; // kullanıcı adını texin içine yazılana eşitlendi
            şifre = this.txtSifre.Text;


            if (kullanıcıadi == "a" && şifre == "a")
            {
                anasayfa sayfa = new anasayfa();// kullanıcı doğru girdiğinde anasayfa formu acılıcak
                sayfa.Show();
                this.Hide();// kullanıcı giriş sayfasını gizledim       
            }
            else
            {
                MessageBox.Show("Giriş Başarısız! Lütfen tekrar deneyiniz");
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // uygulamadan cıkar
        }

        private void KullanıcıGrs_Load(object sender, EventArgs e)
        {

        }
    }
}
