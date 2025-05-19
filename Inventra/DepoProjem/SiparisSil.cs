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
    public partial class SiparisSil: Form
    {
        int secilenID = -1;
        public SiparisSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("BAĞLANTI DİZENİZ");
        SqlDataReader dr;

        private void SiparisSil_Load(object sender, EventArgs e)
        {
        

        }
        

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenID != -1)
                {



                    string sorgu = $"DELETE FROM SIPARISLER WHERE SiparisID={secilenID}";
                    DialogResult result1 = MessageBox.Show("" + secilenID + " Numaralı Siparişi Silmek İstediğinizden Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                        {


                            baglanti.Open();
                            cmd.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show($" Başarıyla Silindi!");
                            LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Sipariş Silme İşlemi", $"ID: {secilenID} Güncellendi");
                            UrunleriListele();
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                secilenID = Convert.ToInt32(bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                string siparisno = bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                lblSiparisNo.Text = $"{siparisno}";

            }
        }
        private void UrunleriListele()
        {
       



        }
    }
}
