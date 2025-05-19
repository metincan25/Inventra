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
    public partial class UrunRapor: Form
    {
        public UrunRapor()
        {
            InitializeComponent();
        }

        
        private void btnSipUrunAdet_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız Veya Yanlış Bir İşlem Yapıldı: " + ex.Message);

            }
        }



        private DataTable UrunlerinSatısSayısı()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_SİPEDİLENURUNADEDİ";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        
        private void btnStoktaAzalanUrunler_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = StoktaAzalanUrunler20(); // SQL'den veri çek
                string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string dosyaYolu = Path.Combine(masaustuYolu, "Stokta 20den Az Kalan Ürünler.xlsx");
                

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
            catch(Exception ex)
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız Veya Yanlış Bir İşlem Yapıldı: " + ex.Message);

            }
        }
        private DataTable StoktaAzalanUrunler20()
        {
            string connStr = "BAĞLANTI DİZENİZ";
            string query = "SELECT * FROM VW_STOKTAZALANURUNLER20";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
