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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        
        private void btnCari_Click_1(object sender, EventArgs e)
        {
            Cari_Hesap hesap = new Cari_Hesap();  /*"carihesap" nesnesinden yeni hesap adında nesne oluşturdum, bu değişkenide döstermesini istedim*/
            hesap.Show();
            this.Hide();
        }
        
        private void btsStok_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok(); //stok sayfasıyla bağlantı kuruluyor
            stok.Show();
            this.Hide();
        }
        

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void btnKarar_Click(object sender, EventArgs e)
        {
            YönetimKarar karar = new YönetimKarar();
            karar.Show();
        }
    }
}
