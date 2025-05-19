using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoProjem
{
    public partial class Urunler: Form
    { 
        private Form currentChildForm;
        public Urunler()
        {
            InitializeComponent();
           
        }
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

        private void Urunler_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Satışcı" && rol != "Üretimci" && rol != "Kullanıcı")
            {
                OpenChildForm(new UrunSil());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Satışcı" && rol != "Üretimci")
            {
                OpenChildForm(new UrunRapor());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Satışcı" && rol != "Üretimci" && rol != "Kullanıcı")
            {
                OpenChildForm(new UrunGuncelle());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Satışcı" && rol != "Üretimci" && rol != "Kullanıcı")
            {
                OpenChildForm(new UrunEkle());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
