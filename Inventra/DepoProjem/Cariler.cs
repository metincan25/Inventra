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
    public partial class Cariler: Form
    {
        private Form currentChildForm;
        public Cariler()
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
        private void Cariler_Load(object sender, EventArgs e)
        {
          
           
            

        }

        private void btnCariEkle_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Kullanıcı" && rol != "Depocu" && rol != "Üretimci")
            {
                OpenChildForm(new CarıEkle());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Kullanıcı" && rol != "Depocu" && rol != "Üretimci" )
            {
                OpenChildForm(new CariSil());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCariGuncelle_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol != "Kullanıcı" && rol != "Depocu" && rol != "Üretimci")
            {
                OpenChildForm(new CariGuncelle());
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
                OpenChildForm(new CariRapor());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
