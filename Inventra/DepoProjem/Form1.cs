using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DepoProjem;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect
        = new SqlConnection(@"BAĞLANTI DİZENİZ");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            if (login_username.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz!"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM USERS WHERE KullanıcıAdı = @username ";
                        string username = login_username.Text.Trim();
                        string inputPassword = login_password.Text.Trim();
                        string hashedInput = HashHelper.HashHelperr.ComputeSha256Hash(inputPassword);
                       

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                string dbHash = reader["SifreHash"].ToString();
                                if (hashedInput == dbHash)
                                {
                                    CurrentUser.CurrentUserr.KullanıcıAdı = reader["KullanıcıAdı"].ToString();
                                    CurrentUser.CurrentUserr.Rol = reader["Rol"].ToString();
                                    MessageBox.Show("Giriş Başarılı,Yönlendiriliyorsunuz.");
                                    // Ana sayfayı aç
                                    AnaSayfa main = new AnaSayfa();
                                    main.Show();
                                    this.Hide();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Şifre yanlış.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Adı Bulunamadı.");
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
        }

        private void login_signupBtn_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
