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
    public partial class UrunEkle: Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MIABVQ8;Initial Catalog=DEPOTAKIP2;Integrated Security=True;");

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text != "" && txtUrunAdı.Text != "" && txtUrunBarkodSeriNo.Text != "" && txtUrunKategorisi.Text != "" && txtUrunMevcutStokMiktari.Text != "" && txtUrunAgırlıgı.Text != "" && txtUrunBırımFıyatı.Text != "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into URUNLISTESI(UrunID,UrunAdı,UrunBarkodSeriNo,UrunKategori,UrunMevcutStokMiktarı,UrunAgırlık,UrunBirimFiyat,UrunTedarikcisi) values(@urunıd1,@urunadı1,@urunbarkodserino1,@urunkategori1,@urunmevcutstokmiktari1,@urunagırlık1,@urunbirimfiyat1,@uruntedarikcisi1)", baglanti);
                    komut.Parameters.AddWithValue("@urunıd1", txtUrunID.Text.Trim());
                    komut.Parameters.AddWithValue("@urunadı1", txtUrunAdı.Text);
                    komut.Parameters.AddWithValue("@urunbarkodserino1", txtUrunBarkodSeriNo.Text.Trim());
                    komut.Parameters.AddWithValue("@urunkategori1", txtUrunKategorisi.Text);
                    komut.Parameters.AddWithValue("@urunmevcutstokmiktari1", txtUrunMevcutStokMiktari.Text.Trim());
                    komut.Parameters.AddWithValue("@urunagırlık1", txtUrunAgırlıgı.Text.Trim());
                    komut.Parameters.AddWithValue("@urunbirimfiyat1", txtUrunBırımFıyatı.Text.Trim());
                    komut.Parameters.AddWithValue("@uruntedarikcisi1", txtUrunTedarikcisi.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Depoya Eklendi!", "Başarılı");
                    LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Ürün Ekleme İşlemi", $"ID: {txtUrunID.Text} Eklendi");
                    txtUrunID.Clear();
                    txtUrunAdı.Clear();
                    txtUrunBarkodSeriNo.Clear();
                    txtUrunKategorisi.Clear();
                    txtUrunMevcutStokMiktari.Clear();
                    txtUrunAgırlıgı.Clear();
                    txtUrunBırımFıyatı.Clear();
                    txtUrunTedarikcisi.Clear();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarısız Veya Yanlış Bir İşlem Yapıldı: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurduğunuzdan Emin Olun");
            }
        }

        private void txtUrunID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void txtUrunBarkodSeriNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunBarkodSeriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void txtUrunMevcutStokMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void txtUrunAgırlıgı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunAgırlıgı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Sadece bir tane nokta (.) olmasına izin ver
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtUrunBırımFıyatı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Sadece bir tane nokta (.) olmasına izin ver
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
