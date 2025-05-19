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
    public partial class CarıEkle: Form
    {
        public CarıEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("BAĞLANTI DİZENİZ");

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarıEkle_Load(object sender, EventArgs e)
        {
            txtHesapNo.MaxLength = 16;
            txtVKNTC.MaxLength = 11;
            SqlDataAdapter da = new SqlDataAdapter("SELECT IlID, IlAdi FROM Iller ORDER BY IlID ASC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbIl.DataSource = dt;
            cmbIl.DisplayMember = "IlAdi";  // ComboBox'ta görünen isim
            cmbIl.ValueMember = "IlID";     // Arka planda saklanan değer
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIl.SelectedValue != null)
            {
                int seciliIlID;
                if (int.TryParse(cmbIl.SelectedValue.ToString(), out seciliIlID))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IlceID, IlceAdi FROM Ilceler WHERE IlID = @IlID", baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@IlID", seciliIlID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbIlce.DataSource = dt;
                    cmbIlce.DisplayMember = "IlceAdi";
                    cmbIlce.ValueMember = "IlceID";
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtCariNo.Text != "" && txtCariAdı.Text != "" && txtCariKodu.Text != "" && txtCariTürü.Text != "" && txtVergiDairesi.Text != "" && txtVKNTC.Text != "" && txtBankaAdı.Text != "" && txtHesapNo.Text != "" && txtIBAN.Text != "" && comboBox1.Text != "" && txtRiskLimiti.Text != "")
            {
                if(txtCariTürü.Text != "1" || txtCariTürü.Text != "2" || txtCariTürü.Text != "3" || txtCariTürü.Text != "4")
                {
                    MessageBox.Show("Lütfen Geçerli Bir Tür Giriniz.");
                }
                else { 


                    try
                    {
                        baglanti.Open();
                        SqlCommand tablo1 = new SqlCommand("INSERT INTO CARIBIL(CariID,CariAdı,CariKodu,CariTuru,VergiDairesi,VergiID_TcNo) VALUES (@cariıd,@cariadı,@carikodu,@carituru,@vergidairesi,@vkn)", baglanti);
                        tablo1.Parameters.AddWithValue("@cariıd", txtCariNo.Text.Trim());
                        tablo1.Parameters.AddWithValue("@cariadı", txtCariAdı.Text);
                        tablo1.Parameters.AddWithValue("@carikodu", txtCariKodu.Text.Trim());
                        tablo1.Parameters.AddWithValue("@carituru", txtCariTürü.Text.Trim());
                        tablo1.Parameters.AddWithValue("@vergidairesi", txtVergiDairesi.Text);
                        tablo1.Parameters.AddWithValue("@vkn", txtVKNTC.Text.Trim());
                        tablo1.ExecuteNonQuery();
                        SqlCommand tablo2 = new SqlCommand("INSERT INTO CARIFINANS(CariID,CariBankaAdi,CariBankaHesapNo,CariIBAN,CariParaBirim,CariRiskLimiti,CariBorc,CariAlacak,CariBakiye) VALUES (@cariıd2,@bankadı,@hesapno,@ıban,@parabirimi,@risklimiti,0,0,0)", baglanti);
                        tablo2.Parameters.AddWithValue("@cariıd2", txtCariNo.Text.Trim());
                        tablo2.Parameters.AddWithValue("@bankadı", txtBankaAdı.Text);
                        tablo2.Parameters.AddWithValue("@hesapno", txtHesapNo.Text.Trim());
                        tablo2.Parameters.AddWithValue("@ıban", txtIBAN.Text);
                        tablo2.Parameters.AddWithValue("@parabirimi", comboBox1.Text);
                        tablo2.Parameters.AddWithValue("@risklimiti", txtRiskLimiti.Text);
                        tablo2.ExecuteNonQuery();
                        SqlCommand tablo3 = new SqlCommand("INSERT INTO CARILT(CariID,CariTelefon,CariMail,CariSite,CariAdres,Cariİlce,CariSehir,CariUlke) VALUES(@cariıd3,@tel,@mail,@site,@adres,@ilce,@il,'TÜRKİYE')", baglanti);
                        tablo3.Parameters.AddWithValue("@cariıd3", txtCariNo.Text.Trim());
                        tablo3.Parameters.AddWithValue("@tel", txtTelNo.Text);
                        tablo3.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                        tablo3.Parameters.AddWithValue("@site", txtSite.Text);
                        tablo3.Parameters.AddWithValue("@adres", txtAdres.Text);
                        tablo3.Parameters.AddWithValue("@ilce", cmbIlce.Text);
                        tablo3.Parameters.AddWithValue("@il", cmbIl.Text);
                        tablo3.ExecuteNonQuery();
                        MessageBox.Show("Cari Başarılı Bir Şekilde Eklenmiştir.", "Başarılı");
                        LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Cari Ekleme İşlemi", $"ID: {txtCariNo.Text} Eklendi");
                        txtCariNo.Clear();
                        txtCariAdı.Clear();
                        txtCariKodu.Clear();
                        txtCariTürü.Clear();
                        txtVergiDairesi.Clear();
                        txtVKNTC.Clear();
                        txtBankaAdı.Clear();
                        txtHesapNo.Clear();
                        txtIBAN.Clear();

                        txtRiskLimiti.Clear();
                        txtTelNo.Clear();
                        txtMail.Clear();
                        txtSite.Clear();
                        txtAdres.Clear();


                        baglanti.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı Hatası Veya Yanlış Bir İşlem Yapıldı" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Bilgileri Giriniz.");
            }
        }

        private void txtVKNTC_TextChange(object sender, EventArgs e)
        {
            
        }

        private void txtVKNTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void txtCariNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void txtCariTürü_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtCariTürü_TextChange(object sender, EventArgs e)
        {

        }

        private void txtVergiDairesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVergiDairesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtBankaAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }
        private void txtHesapNo_TextChange(object sender, EventArgs e)
        {
           
        }

        private void txtIBAN_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtIBAN_TextChange(object sender, EventArgs e)
        {
           
        }

        private void txtParaBirimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtRiskLimiti_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRiskLimiti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCariAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
