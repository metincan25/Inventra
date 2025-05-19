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
    public partial class CariRapor: Form
    {
        public CariRapor()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable Cariler()
        {
            string connStr = "BAĞLANTI DİZENİZ;
            string query = "SELECT * FROM CARILER";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private DataTable MusteriSip()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_MUSTERİSİPSAYISI";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private DataTable TopSiparis()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_MUSTERİHARCAMA";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void btnMüşteriyeAitHarcama_Click(object sender, EventArgs e)
        {
            DataTable dt = TopSiparis(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Müşteriye Ait Toplam Harcama.xlsx");


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

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            DataTable dt = Cariler(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Cari Listesi.xlsx");


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

        private void btnMüşteriyeAitToplamSip_Click(object sender, EventArgs e)
        {
            DataTable dt = MusteriSip(); // SQL'den veri çek
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaYolu = Path.Combine(masaustuYolu, "Müşteriye Ait Toplam Sipariş.xlsx");


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
    }
}
