using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoProjem
{
    public partial class SiparisEkle: Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti
        = new SqlConnection(@"BAĞLANTI DİZENİZ");
        SqlDataReader dr;
        DateTime dtSecilenTarih;
        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked)
            {
                dtSecilenTarih = DateTime.Now; // datetime olarak sakla
                txtSiparisTarihi.Text = dtSecilenTarih.ToString("dd-MM-yyyy HH:mm:ss");
                
            }
            else
            {
                txtSiparisTarihi.Clear();
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            
            if (txtUrunNo.Text != "" && txtUrunAdı.Text != "" && txtSiparisNo.Text != "" && txtDurum.Text != "" && txtMusteriNo.Text != "" && txtUrunBirimFiyatı.Text != "" && txtSiparisTarihi.Text != "" && txtUrunMiktarı.Text != "")
            {
                if (txtDurum.Text == "ONAYLANDI" || txtDurum.Text == "BEKLEMEDE")
                {


                    try
                    {
                        using (SqlConnection baglanti2 = new SqlConnection("BAĞLANTI DİZENİZ"))
                        {
                            baglanti2.Open();

                            // 1. Ürün kontrolü
                            using (SqlCommand urunsorgu = new SqlCommand("SELECT * FROM URUNLISTESI WHERE UrunID=@uı", baglanti2))
                            {
                                urunsorgu.Parameters.AddWithValue("@uı", txtUrunNo.Text);
                                using (SqlDataReader dr1 = urunsorgu.ExecuteReader())
                                {
                                    if (!dr1.Read())
                                    {
                                        
                                        MessageBox.Show("Ürün bulunamadı");
                                        return;
                                        
                                    }
                                    
                                }
                            }

                            // 2. Müşteri kontrolü
                            using (SqlCommand carisorgu = new SqlCommand("SELECT * FROM CARIBIL WHERE CariID=@mı", baglanti2))
                            {
                                carisorgu.Parameters.AddWithValue("@mı", txtMusteriNo.Text);
                                using (SqlDataReader dr2 = carisorgu.ExecuteReader())
                                {
                                    if (!dr2.Read())
                                    {
                                        MessageBox.Show("Müşteri bulunamadı");
                                        return;
                                    }
                                    
                                }
                            }

                            // 3. Mevcut stok kontrolü
                            using (SqlCommand stokCmd = new SqlCommand("SELECT UrunMevcutStokMiktarı FROM URUNLISTESI WHERE UrunID=@uı", baglanti2))
                            {
                                stokCmd.Parameters.AddWithValue("@uı", txtUrunNo.Text);
                                object sonuc = stokCmd.ExecuteScalar();

                                if (sonuc != null)
                                {
                                    int mevcut = Convert.ToInt32(sonuc);
                                    int istenen = Convert.ToInt32(txtUrunMiktarı.Text);

                                    if (mevcut >= istenen)
                                    {
                                        double birimFiyat = Convert.ToDouble(txtUrunBirimFiyatı.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                                        double toplam = birimFiyat * istenen;

                                        using (SqlCommand insertCmd = new SqlCommand("INSERT INTO SIPARISLER (SiparisID, MusteriID, ToplamTutar, Durum, UrunID, UrunAdı, BirimFiyat, Miktar, SiparisTarihi) VALUES (@sid, @mid, @toplam, @durum, @uid, @uad, @bf, @miktar, @tarih)", baglanti2))
                                        {
                                            insertCmd.Parameters.AddWithValue("@sid", txtSiparisNo.Text.Trim());
                                            insertCmd.Parameters.AddWithValue("@mid", txtMusteriNo.Text.Trim());
                                            insertCmd.Parameters.AddWithValue("@toplam", toplam);
                                            insertCmd.Parameters.AddWithValue("@durum", txtDurum.Text.Trim());
                                            insertCmd.Parameters.AddWithValue("@uid", txtUrunNo.Text.Trim());
                                            insertCmd.Parameters.AddWithValue("@uad", txtUrunAdı.Text);
                                            insertCmd.Parameters.AddWithValue("@bf", birimFiyat);
                                            insertCmd.Parameters.AddWithValue("@miktar", txtUrunMiktarı.Text.Trim());

                                            DateTime tarih = bunifuCheckBox1.Checked ? dtSecilenTarih : DateTime.Parse(txtSiparisTarihi.Text);
                                            insertCmd.Parameters.AddWithValue("@tarih", tarih);

                                            insertCmd.ExecuteNonQuery();
                                            MessageBox.Show("SİPARİŞ BAŞARIYLA OLUŞTURULDU.");
                                            LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Sipariş Ekleme İşlemi", $"ID: {txtSiparisNo.Text} Eklendi");
                                            txtSiparisNo.Clear();
                                            txtMusteriNo.Clear();
                                            txtSiparisTarihi.Clear();
                                            txtDurum.Clear();
                                            txtUrunNo.Clear();
                                            txtUrunAdı.Clear();
                                            txtUrunBirimFiyatı.Clear();
                                            txtUrunMiktarı.Clear();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Yetersiz stok.");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HATA: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Durum Kısmına 'ONAYLANDI' veya 'BEKLEMEDE' yazınız. ");
                }



            }
            else
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurduğunuza Emin Olun");
            }
            
        }

        private void UrunBilgileriniGetir()
        {

            {
                try
                {

                    baglanti.Open();
                    string query = "SELECT UrunAdı,UrunBirimFiyat FROM URUNLISTESI WHERE UrunID = @UrunNo";
                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@UrunNo", txtUrunNo.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                txtUrunAdı.Text = reader["UrunAdı"].ToString();
                                txtUrunBirimFiyatı.Text = reader["UrunBirimFiyat"].ToString();

                            }
                            else
                            {

                                txtUrunAdı.Clear();
                                txtUrunBirimFiyatı.Clear();
                            }
                            

                        }
                        baglanti.Close();
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);

                }


            }
        }
        private void txtUrunNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtUrunNo_TextChange(object sender, EventArgs e)
        {
          UrunBilgileriniGetir();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSiparisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void txtUrunNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUrunMiktarı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
