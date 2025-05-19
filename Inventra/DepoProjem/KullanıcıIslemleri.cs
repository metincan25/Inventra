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
    public partial class KullanıcıIslemleri: Form
    {

        string secilenKolon = "";
        int secilenID = -1;
        string secilenVeritabaniKolon;
        public KullanıcıIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection connect
          = new SqlConnection(@"BAĞLANTI DİZENİZ");

        private void KullanıcıIslemleri_Load(object sender, EventArgs e)
        {
            
           

        }
        private void Listele()
        {
           



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectUsername = "SELECT COUNT(KullanıcıAdı) FROM USERS WHERE KullanıcıAdı = @user";

                    using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@user", txtYeniDeğer.Text.Trim());
                        int count = (int)checkUser.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(txtYeniDeğer.Text.Trim() + " Bu kullanıcı adını kullanamazsınız"
                                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {


                            if (secilenKolon != "" && secilenID != -1)
                            {
                                string yeniDeger = txtYeniDeğer.Text;
                                string sorgu = $"UPDATE USERS SET {secilenVeritabaniKolon} = @deger WHERE ID = @id";

                                using (SqlCommand cmd = new SqlCommand(sorgu, connect))
                                {
                                    cmd.Parameters.AddWithValue("@deger", yeniDeger);
                                    cmd.Parameters.AddWithValue("@id", secilenID);

                                    
                                    cmd.ExecuteNonQuery();
                                    

                                    MessageBox.Show($"{secilenKolon} başarıyla güncellendi!");
                                    Listele();

                                }


                                secilenKolon = "";
                                secilenID = -1;
                                txtYeniDeğer.Clear();
                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarısız Veya Yanlış Bir İşlem Yapıldı: " + ex.Message);

                }
                finally{
                    connect.Close();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                secilenKolon = bunifuDataGridView1.Columns[e.ColumnIndex].HeaderText;


                if (secilenKolon == "ID")
                {
                    MessageBox.Show("ID Güncellenemez.");
                    return;
                }
                secilenVeritabaniKolon = bunifuDataGridView1.Columns[e.ColumnIndex].DataPropertyName;
                txtYeniDeğer.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                secilenID = Convert.ToInt32(bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value);


                this.Text = $"Seçilen Sütun: {secilenKolon} /  ID: {secilenID}";

                
                
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKolon != "" && secilenID != -1)
            {
                string password = txtSifre.Text.Trim();
                string hashedPassword = HashHelper.HashHelperr.ComputeSha256Hash(password);
                connect.Open();
                SqlCommand sifreg = new SqlCommand("UPDATE USERS SET SifreHash = @sifre WHERE ID = @id", connect);
                sifreg.Parameters.AddWithValue("@sifre", hashedPassword);
                sifreg.Parameters.AddWithValue("@id", secilenID);
                sifreg.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi.");
                secilenKolon = "";
                secilenID = -1;
                txtSifre.Clear();

                connect.Close();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenID != -1)
                {



                    string sorgu = $"DELETE FROM USERS WHERE ID={secilenID}";
                    DialogResult result1 = MessageBox.Show("" + secilenID + " Numaralı Kullanıcıyı Silmek İstediğinizden Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand(sorgu, connect))
                        {


                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show($" Kullanıcı Başarıyla Silindi!");
                           

                            Listele();
                        }
                    }



                    secilenID = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız Veya Yanlış Bir İşlem Yapıldı: " + ex.Message);

            }
        }
    }
}
