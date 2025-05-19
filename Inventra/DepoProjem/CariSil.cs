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
    public partial class CariSil: Form
    {
        int secilenID = -1;
        public CariSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("BAĞLANTI DİZENİZ");
        SqlDataReader dr;
        private void CariSil_Load(object sender, EventArgs e)
        {
            
           

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(secilenID != -1)
                {
                    string sorgu = $"DELETE FROM CARIBIL WHERE CariID={secilenID}";
                    string sorgu2 = $"DELETE FROM CARILT WHERE CariID={secilenID}";
                    string sorgu3 = $"DELETE FROM CARIFINANS WHERE CariID={secilenID}";
                    DialogResult result1 = MessageBox.Show("" + secilenID + " Numaralı Cariyi Silmek İstediğinizden Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                        {


                            baglanti.Open();
                            cmd.ExecuteNonQuery();
                            baglanti.Close();



                            using (SqlCommand cmd2 = new SqlCommand(sorgu2, baglanti))
                            {


                                baglanti.Open();
                                cmd2.ExecuteNonQuery();
                                baglanti.Close();


                                using (SqlCommand cmd3 = new SqlCommand(sorgu3, baglanti))
                                {


                                    baglanti.Open();
                                    cmd3.ExecuteNonQuery();
                                    baglanti.Close();

                                }
                                Listele();
                                MessageBox.Show($" Başarıyla Silindi!");
                                LogHelper.LogHelperr.LogAction(CurrentUser.CurrentUserr.KullanıcıAdı, "Cari Silme İşlemi", $"ID: {secilenID} Silindi");
                            }
                        }   
                    } 
                    secilenID = -1;
                }
            }
            catch(Exception ex)
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
                label2.ForeColor = Color.White;
                label2.Text = $"{siparisno}";

            }
        }
        private void Listele()
        {


            


        }
    }
}
