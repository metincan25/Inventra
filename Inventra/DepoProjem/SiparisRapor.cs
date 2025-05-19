using OfficeOpenXml;
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
using System.IO;
using OfficeOpenXml.Style;

namespace DepoProjem
{
    public partial class SiparisRapor: Form
    {
        public SiparisRapor()
        {
            InitializeComponent();
        }

        private void SiparisRapor_Load(object sender, EventArgs e)
        {

        }
        private DataTable BugününRaporu()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_BUGUNUNSIPARISLERI";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnBugünSiparisleri_Click(object sender, EventArgs e)
        {
            DataTable dt = BugününRaporu(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Bugünün Sipariş Raporu.xlsx");
           

            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Rapor Listesi");
                ws.Cells["A1"].LoadFromDataTable(dt, true); // Verileri yükle
                using (ExcelRange rng = ws.Cells[1, 1, 1, dt.Columns.Count])
                {
                    rng.Style.Font.Bold = true; // Kalın yap
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid; // Arka plan stili
                    rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray); // Açık gri renk
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ortala
                }
                using (ExcelRange rng = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count])
                {
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
                ws.Cells.AutoFitColumns();


                File.WriteAllBytes(dosyaYolu, excel.GetAsByteArray()); // Dosyayı oluştur
            }

            DialogResult dr = MessageBox.Show($"Excel dosyası başarıyla oluşturuldu: {dosyaYolu}  Raporu Açmak İster Misiniz?", "Rapor Oluşturuldu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(dosyaYolu);

            }
        }
        private DataTable VerileriGetir()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM SIPARISLER ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            DataTable dt = VerileriGetir(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Siparişler Raporu.xlsx");
            

            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Sipariş Listesi");
                ws.Cells["A1"].LoadFromDataTable(dt, true); // Verileri yükle
                using (ExcelRange rng = ws.Cells[1, 1, 1, dt.Columns.Count])
                {
                    rng.Style.Font.Bold = true; // Kalın yap
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid; // Arka plan stili
                    rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray); // Açık gri renk
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ortala
                }
                using (ExcelRange rng = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count])
                {
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
                ws.Cells.AutoFitColumns();


                File.WriteAllBytes(dosyaYolu, excel.GetAsByteArray()); // Dosyayı oluştur
            }

            DialogResult dr = MessageBox.Show($"Excel dosyası başarıyla oluşturuldu: {dosyaYolu}  Raporu Açmak İster Misiniz?", "Rapor Oluşturuldu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(dosyaYolu);

            }
        }
        private DataTable GünlükRaporlar()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_GUNLUKRAPOR ORDER BY Tarih DESC";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnGunlıkSiparisRaporları_Click(object sender, EventArgs e)
        {
            DataTable dt = GünlükRaporlar(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Günlük Sipariş Raporu.xlsx");
            

            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Rapor Listesi");
                ws.Cells["A1"].LoadFromDataTable(dt, true); // Verileri yükle
                using (ExcelRange rng = ws.Cells[1, 1, 1, dt.Columns.Count])
                {
                    rng.Style.Font.Bold = true; // Kalın yap
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid; // Arka plan stili
                    rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray); // Açık gri renk
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ortala
                }
                using (ExcelRange rng = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count])
                {
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
                ws.Cells.AutoFitColumns();


                File.WriteAllBytes(dosyaYolu, excel.GetAsByteArray()); // Dosyayı oluştur
            }

            DialogResult dr = MessageBox.Show($"Excel dosyası başarıyla oluşturuldu: {dosyaYolu}  Raporu Açmak İster Misiniz?", "Rapor Oluşturuldu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(dosyaYolu);

            }
        }
        private DataTable GünBazlıSatışRaporu()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_GUNLUKCİRO";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnGunlukCiro_Click(object sender, EventArgs e)
        {
            DataTable dt = GünBazlıSatışRaporu(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Gün Bazlı Satış Raporu.xlsx");
            

            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Rapor Listesi");
                ws.Cells["A1"].LoadFromDataTable(dt, true); // Verileri yükle
                using (ExcelRange rng = ws.Cells[1, 1, 1, dt.Columns.Count])
                {
                    rng.Style.Font.Bold = true; // Kalın yap
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid; // Arka plan stili
                    rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray); // Açık gri renk
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ortala
                }
                using (ExcelRange rng = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count])
                {
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
                ws.Cells.AutoFitColumns();


                File.WriteAllBytes(dosyaYolu, excel.GetAsByteArray()); // Dosyayı oluştur
            }

            DialogResult dr = MessageBox.Show($"Excel dosyası başarıyla oluşturuldu: {dosyaYolu}  Raporu Açmak İster Misiniz?", "Rapor Oluşturuldu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(dosyaYolu);

            }
        }
        private DataTable UrunlerinSatısSayısı()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_URUNDENNEKADARSATILDI";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnUrunSatıs_Click(object sender, EventArgs e)
        {
            DataTable dt = UrunlerinSatısSayısı(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Ürünlerin Satış Miktarı Raporu.xlsx");
            

            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Rapor Listesi");
                ws.Cells["A1"].LoadFromDataTable(dt, true); // Verileri yükle
                using (ExcelRange rng = ws.Cells[1, 1, 1, dt.Columns.Count])
                {
                    rng.Style.Font.Bold = true; // Kalın yap
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid; // Arka plan stili
                    rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray); // Açık gri renk
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ortala
                }
                using (ExcelRange rng = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count])
                {
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
                ws.Cells.AutoFitColumns();


                File.WriteAllBytes(dosyaYolu, excel.GetAsByteArray()); // Dosyayı oluştur
            }

            DialogResult dr = MessageBox.Show($"Excel dosyası başarıyla oluşturuldu: {dosyaYolu}  Raporu Açmak İster Misiniz?", "Rapor Oluşturuldu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(dosyaYolu);

            }

        }
        private DataTable UrunKarZarar()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_KARZARARDURUMU  ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnKarZarar_Click(object sender, EventArgs e)
        {
            DataTable dt = UrunKarZarar();// SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Ürün Kâr-Zarar Raporu.xlsx");
            

            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Rapor Listesi");
                ws.Cells["A1"].LoadFromDataTable(dt, true); // Verileri yükle
                using (ExcelRange rng = ws.Cells[1, 1, 1, dt.Columns.Count])
                {
                    rng.Style.Font.Bold = true; // Kalın yap
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid; // Arka plan stili
                    rng.Style.Fill.BackgroundColor.SetColor(Color.LightGray); // Açık gri renk
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ortala
                }
                using (ExcelRange rng = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count])
                {
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
                ws.Cells.AutoFitColumns();


                File.WriteAllBytes(dosyaYolu, excel.GetAsByteArray()); // Dosyayı oluştur
            }

            DialogResult dr = MessageBox.Show($"Excel dosyası başarıyla oluşturuldu: {dosyaYolu}  Raporu Açmak İster Misiniz?", "Rapor Oluşturuldu", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(dosyaYolu);

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
