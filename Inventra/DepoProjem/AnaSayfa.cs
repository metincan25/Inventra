using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;

namespace DepoProjem
{
    public partial class AnaSayfa: Form
    {
        //Alanlar
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Constructor
        public AnaSayfa()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(97, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
            public static System.Drawing.Color color7 = System.Drawing.Color.FromArgb(110, 82, 200);
            public static System.Drawing.Color color8 = System.Drawing.Color.FromArgb(85, 221, 186);

        }
        //Metotlar
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                ıconPictureBox1.IconChar = currentBtn.IconChar;
                ıconPictureBox1.IconColor = color;



            }
        }

        private void OpenChildForm( Form childForm)
        {
            if (currentChildForm != null) { 
            currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDestkop.Controls.Add(childForm);
            panelDestkop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
               
                currentBtn.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;


            lblKullanıcı.Text = $"{CurrentUser.CurrentUserr.KullanıcıAdı} ({CurrentUser.CurrentUserr.Rol})";
            
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            OpenChildForm(new GenelDurum());


        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Hareketler());
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAPIM AŞAMASINDA");
            
        
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Cariler());
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Siparisler());
            
           
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Urunler());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            ıconPictureBox1.IconChar = IconChar.Home;
            ıconPictureBox1.IconColor =  System.Drawing.Color.MediumPurple;
            lblTitleChildForm.Text = "Ana Sayfa";

        }
        


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Inventra'dan Çıkmak İstediğinize Emin Misiniz?", "INVENTRA", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                label2.Text = "↙"; // Küçültme simgesi gibi
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                label2.Text = "↗"; // Büyütme simgesi gibi
            }
        }

        private void lblKullanıcı_Click(object sender, EventArgs e)
        {

        }

        private void btnİslemGecmisi_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if (rol == "Yönetici" || rol == "Müdür" || rol == "Admin")
            {

                ActivateButton(sender, RGBColors.color7);
                OpenChildForm(new IslemGecmisi());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnKullanıcıKayıtı_Click(object sender, EventArgs e)
        {
            string rol = CurrentUser.CurrentUserr.Rol;
            if ( rol == "Admin")
            {
                ActivateButton(sender, RGBColors.color8);
                OpenChildForm(new KullanıcıEkle());
            }
            else
            {
                MessageBox.Show("Bu Bölüme Erişim Yetkiniz Yok!", "YETKİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
