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
    public partial class SiparisGuncelle: Form
    {
        string secilenKolon = "";
        int secilenID = -1;
        string secilenVeritabaniKolon;
        public SiparisGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection connect
         = new SqlConnection(@"BAĞLANTI DİZENİZ");
        private void SiparisGuncelle_Load(object sender, EventArgs e)
        {
            

        }
        private void UrunleriListele()
        {
            


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenKolon != "" && secilenID != -1)
                {
                    string yeniDeger = txtYeniDeğer.Text;
                    string sorgu = $"UPDATE SIPARISLER SET {secilenVeritabaniKolon} = @deger WHERE SiparisID = @id";

                    using (SqlCommand cmd = new SqlCommand(sorgu, connect))
                    {
                        cmd.Parameters.AddWithValue("@deger", yeniDeger);
                        cmd.Parameters.AddWithValue("@id", secilenID);

                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show($"{secilenKolon} başarıyla güncellendi!");
                        LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Sipariş Güncelleme İşlemi", $"Sütun Adı: {secilenKolon} Güncellendi");
                        UrunleriListele();
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


                if (secilenKolon == "Sipariş No")
                {
                    MessageBox.Show("Sipariş Numarası Güncellenemez.");
                    return;
                }
                secilenVeritabaniKolon = bunifuDataGridView1.Columns[e.ColumnIndex].DataPropertyName;
                txtYeniDeğer.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                secilenID = Convert.ToInt32(bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value);


                this.Text = $"Seçilen Sütun: {secilenKolon} / Sipariş ID: {secilenID}";

                string siparisno = bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                lblSecilenUrun.Text = $"{siparisno}";
                lblSecilenAlan.Text = $"{secilenKolon}";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtYeniDeğer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
