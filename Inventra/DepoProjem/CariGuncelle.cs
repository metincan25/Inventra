using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DepoProjem
{
    public partial class CariGuncelle: Form
    {
        string secilenKolon = "";
        int secilenID = -1;
        string secilenVeritabaniKolon;
        public CariGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection connect
        = new SqlConnection(@"BAĞLANTI DİZENİZ");

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Listele()
        {
           

        }
        private void CariGuncelle_Load(object sender, EventArgs e)
        {
          
           

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (secilenKolon != "" && secilenID != -1)
                {
                    string yeniDeger = txtYeniDeğer.Text;
                    int selectedColumnIndex = bunifuDataGridView1.CurrentCell.ColumnIndex;
                    int selectedRowIndex = bunifuDataGridView1.CurrentCell.RowIndex;

                    string cariNo = bunifuDataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                    string cariAdı = bunifuDataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                    string cariKodu = bunifuDataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                    string cariTuru = bunifuDataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                    string vergiDairesi = bunifuDataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
                    string vkntc = bunifuDataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
                    string bankAdı = bunifuDataGridView1.Rows[selectedRowIndex].Cells[6].Value.ToString();
                    string hesapno = bunifuDataGridView1.Rows[selectedRowIndex].Cells[7].Value.ToString();
                    string ıban = bunifuDataGridView1.Rows[selectedRowIndex].Cells[8].Value.ToString();
                    string parabirimi = bunifuDataGridView1.Rows[selectedRowIndex].Cells[9].Value.ToString();
                    string telefon = bunifuDataGridView1.Rows[selectedRowIndex].Cells[10].Value.ToString();
                    string mail = bunifuDataGridView1.Rows[selectedRowIndex].Cells[11].Value.ToString();
                    string site = bunifuDataGridView1.Rows[selectedRowIndex].Cells[12].Value.ToString();
                    string adres = bunifuDataGridView1.Rows[selectedRowIndex].Cells[13].Value.ToString();
                    string sehir = bunifuDataGridView1.Rows[selectedRowIndex].Cells[14].Value.ToString();
                    string ilce = bunifuDataGridView1.Rows[selectedRowIndex].Cells[15].Value.ToString();

                    if (selectedColumnIndex >= 0 && selectedColumnIndex <= 5)
                    {

                        string sorgu = $"UPDATE CARIBIL SET {secilenVeritabaniKolon} = @deger WHERE CariID = @id";

                        using (SqlCommand cmd = new SqlCommand(sorgu, connect))
                        {
                            cmd.Parameters.AddWithValue("@deger", yeniDeger);
                            cmd.Parameters.AddWithValue("@id", secilenID);

                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();

                            MessageBox.Show($"{secilenKolon} başarıyla güncellendi!");
                            LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Cari Güncelleme İşlemi", $"Sütun Adı: {secilenKolon} Güncellendi");

                            Listele();
                        }
                    }
                    else if (selectedColumnIndex >= 6 && selectedColumnIndex <= 9)
                    {
                        string sorgu = $"UPDATE CARIFINANS SET {secilenVeritabaniKolon} = @deger WHERE CariID = @id";

                        using (SqlCommand cmd = new SqlCommand(sorgu, connect))
                        {
                            cmd.Parameters.AddWithValue("@deger", yeniDeger);
                            cmd.Parameters.AddWithValue("@id", secilenID);

                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();

                            MessageBox.Show($"{secilenKolon} başarıyla güncellendi!");
                            LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Cari Güncelleme İşlemi", $"Sütun Adı: {secilenKolon} Güncellendi");
                            Listele();
                        }
                    }
                    else if (selectedColumnIndex >= 10 && selectedColumnIndex <= 15)
                    {
                        string sorgu = $"UPDATE CARILT SET {secilenVeritabaniKolon} = @deger WHERE CariID = @id";

                        using (SqlCommand cmd = new SqlCommand(sorgu, connect))
                        {
                            cmd.Parameters.AddWithValue("@deger", yeniDeger);
                            cmd.Parameters.AddWithValue("@id", secilenID);

                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();

                            MessageBox.Show($"{secilenKolon} başarıyla güncellendi!");
                            LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Cari Güncelleme İşlemi", $"Sütun Adı: {secilenKolon} Güncellendi");
                            Listele();
                        }
                    }


                    secilenKolon = "";
                    secilenID = -1;
                    txtYeniDeğer.Clear();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız Veya Yanlış Bir İşlem Yapıldı: " + ex.Message);

            }
        }
            
        

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                secilenKolon = bunifuDataGridView1.Columns[e.ColumnIndex].HeaderText;


                if (secilenKolon == "CariNo")
                {
                    MessageBox.Show("Cari Numarası Numarası Güncellenemez.");
                    return;
                }
                secilenVeritabaniKolon = bunifuDataGridView1.Columns[e.ColumnIndex].DataPropertyName;
                txtYeniDeğer.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                secilenID = Convert.ToInt32(bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value);


                this.Text = $"Seçilen Sütun: {secilenKolon} / Ürün ID: {secilenID}";

                string carino = bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                lblSecilenCari.Text = $"{carino}";
                lblSecilenAlan.Text = $"{secilenKolon}";
            }
        }
    }
}
