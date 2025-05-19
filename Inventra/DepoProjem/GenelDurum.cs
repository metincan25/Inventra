using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoProjem
{
    public partial class GenelDurum: Form
    {
        public GenelDurum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti
       = new SqlConnection(@"BAĞLANTI DİZENİZ");
        private void GenelDurum_Load(object sender, EventArgs e)
        {
            //try
            //{
                timer1.Start();
                VerileriGuncelle();
            //}
            /*catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu " + ex.Message);
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }
        private void VerileriGuncelle()
        {
            baglanti.Open();
            SqlCommand urunsayisi = new SqlCommand("SELECT COUNT(*) FROM URUNLISTESI", baglanti);
            lblTopUrun.Text = urunsayisi.ExecuteScalar().ToString();
            SqlCommand stoksayisi = new SqlCommand("SELECT SUM(CONVERT(INT,UrunMevcutStokMiktarı)) FROM URUNLISTESI", baglanti);
            lblTopStok.Text = stoksayisi.ExecuteScalar()?.ToString() ?? "0";
            SqlCommand kritikstok = new SqlCommand("SELECT UrunAdı FROM URUNLISTESI WHERE TRY_CAST(UrunMevcutStokMiktarı AS INT) < 10", baglanti);
            SqlDataReader reader = kritikstok.ExecuteReader();
            listKritik.Items.Clear();
            while (reader.Read())
            {
                listKritik.Items.Add(reader["UrunAdı"].ToString());
            }
            reader.Close();
            SqlCommand stokolmayan = new SqlCommand("SELECT UrunAdı FROM URUNLISTESI WHERE TRY_CAST(UrunMevcutStokMiktarı AS INT) = 0", baglanti);
            SqlDataReader reader2 = stokolmayan.ExecuteReader();
            listStokOlmayan.Items.Clear();
            while (reader2.Read())
            {
                listStokOlmayan.Items.Add(reader2["UrunAdı"].ToString());
            }
            reader2.Close();
            SqlCommand beklemedesip = new SqlCommand("SELECT SiparisID FROM SIPARISLER WHERE Durum='BEKLEMEDE'", baglanti);
            SqlDataReader reader3 = beklemedesip.ExecuteReader();
            listBeklemede.Items.Clear();
            while (reader3.Read())
            {
                listBeklemede.Items.Add(reader3["SiparisID"].ToString());
            }
            reader3.Close();
            SqlCommand onaylanansip = new SqlCommand("SELECT COUNT(*) FROM SIPARISLER WHERE Durum='ONAYLANDI'", baglanti);
            lblOnaylananSip.Text = onaylanansip.ExecuteScalar().ToString();
            SqlCommand topsatıstutarı = new SqlCommand("SELECT SUM(CONVERT(DECIMAL(18,2),ToplamTutar)) FROM SIPARISLER", baglanti);
            lblSatısTutarı.Text = topsatıstutarı.ExecuteScalar().ToString();
            SqlCommand alacaktutarı = new SqlCommand("SELECT SUM(CONVERT(DECIMAL(18,2),CariAlacak)) FROM CARIFINANS ", baglanti);
            lblAlacak.Text = alacaktutarı.ExecuteScalar().ToString();
            SqlCommand borctutarı = new SqlCommand("SELECT SUM(CONVERT(DECIMAL(18,2),CariBorc)) FROM CARIFINANS ", baglanti);
            lblBorc.Text = borctutarı.ExecuteScalar().ToString();
            SqlCommand carisayısı = new SqlCommand("SELECT COUNT(*) FROM CARIBIL", baglanti);
            lblCari.Text = carisayısı.ExecuteScalar().ToString();
            SqlCommand hammadde = new SqlCommand("SELECT COUNT(*) FROM HAMMADELER",baglanti);
            lblHammadde.Text = hammadde.ExecuteScalar().ToString();


            baglanti.Close();
        }
    }
}
