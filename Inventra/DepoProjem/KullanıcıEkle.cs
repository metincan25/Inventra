using EmployeeManagementSystem;
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
    public partial class KullanıcıEkle : Form
    {
        private Form currentChildForm;
        public KullanıcıEkle()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"BAĞLANTI DİZENİZ");
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KullanıcıEkle_Load(object sender, EventArgs e)
        {
          
           


        }
        private void Listele()
        {
           
         

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == ""
                || txtKullanıcıAdı.Text == "" || txtSifre.Text == "" || txtSifreT.Text == "" || cmbRol.Text == "")
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                    if (txtSifre.Text == txtSifreT.Text)
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            try
                            {
                                connect.Open();

                                string selectUsername = "SELECT COUNT(KullanıcıAdı) FROM USERS WHERE KullanıcıAdı = @user";

                                using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                                {
                                    checkUser.Parameters.AddWithValue("@user", txtKullanıcıAdı.Text.Trim());
                                    int count = (int)checkUser.ExecuteScalar();

                                    if (count >= 1)
                                    {
                                        MessageBox.Show(txtKullanıcıAdı.Text.Trim() + " Bu kullanıcı adını kullanamazsınız"
                                            , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {


                                        string insertData = "INSERT INTO USERS " +
                                        "(KullanıcıAdı, SifreHash ,Rol ,AdSoyad) " +
                                            "VALUES(@username, @password, @rol,@adsoyad)";
                                        string username = txtKullanıcıAdı.Text.Trim();
                                        string password = txtSifre.Text.Trim();
                                        string adsoyad = txtAdSoyad.Text;
                                        string hashedPassword = HashHelper.HashHelperr.ComputeSha256Hash(password);
                                        string rol;
                                        if (chkAdminmi.Checked)
                                        {
                                            rol = "Admin";
                                        }
                                        else
                                        {
                                            rol = cmbRol.Text;
                                        }

                                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                        {
                                            cmd.Parameters.AddWithValue("@username", username);
                                            cmd.Parameters.AddWithValue("@password", hashedPassword);
                                            cmd.Parameters.AddWithValue("@rol", rol);
                                            cmd.Parameters.AddWithValue("@adsoyad", adsoyad);


                                            cmd.ExecuteNonQuery();

                                            MessageBox.Show("Başarıyla Kullanıcı Kayıt Edildi."
                                                , "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            Listele();
                                        }
                                    }
                                }




                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex
                            , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                connect.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.", "Error");
                    }
                
            }
        }

        private void chkAdminmi_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            cmbRol.Enabled = !chkAdminmi.Checked;
            if (chkAdminmi.Checked)
            {
                cmbRol.Text = "";
            }
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

        private void btnKullanıcıİslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KullanıcıIslemleri());

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
