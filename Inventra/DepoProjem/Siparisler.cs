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
    public partial class Siparisler: Form
    {
        private Form currentChildForm;
        public Siparisler()
        {
            InitializeComponent();
        }
        SqlConnection connect
      = new SqlConnection(@"BAĞLANTI DİZENİZ");
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }
        private void Siparisler_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Depocu" && rol != "Üretimci" && rol!="Kullanıcı")
            {
                OpenChildForm(new SiparisEkle());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Depocu" && rol != "Üretimci" && rol != "Kullanıcı")
            {
                OpenChildForm(new SiparisSil());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Depocu" && rol != "Üretimci" && rol != "Kullanıcı")
            {
                OpenChildForm(new SiparisGuncelle());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Depocu" && rol != "Üretimci")
            {
                OpenChildForm(new SiparisRapor());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {

                int islemID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);


                string yeniDurum = "ONAYLANDI";


                bunifuDataGridView1.SelectedRows[0].Cells[5].Value = yeniDurum;

                connect.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE SIPARISLER SET Durum=@durum WHERE SiparisID=@ıı", connect);
                guncelle.Parameters.AddWithValue("@durum", yeniDurum);
                guncelle.Parameters.AddWithValue("@ıı", islemID);
                guncelle.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Sipariş başarıyla onaylandı!");
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariş seçin!", "Hata");
            }
        }
    }
}
