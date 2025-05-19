# 📦 Inventra - Depo ve Stok Takip Uygulaması

Inventra, küçük ve orta ölçekli işletmelerin **stok**, **sipariş** ve  **cari** gib işlemlerini kolayca yönetebileceği kullanıcı tabanlı bir depo takip sistemidir. Uygulama C# WinForms ve SQL Server teknolojileriyle geliştirilmiştir.

## 🚀 Özellikler

- 👤 ** Aynı Ağ Üzerinden Çoklu Kullanıcı Girişi**
- 📦 **Ürün Yönetimi**
  - Ürün ekle, sil, güncelle
  - Mevcut stok takibi
  - Kritik stok seviyesi uyarısı
  - Ürün Raporları
- 📑 **Sipariş Yönetimi**
  - Sipariş oluşturma, silme, güncelleme
  - Sipariş onaylama ve beklemede durumu
  - Sipariş raporları
- 🧾 **Cari Yönetimi**
  - Cari tanımlama ve listeleme
  - Sipariş-cari bağlantısı
- 📊 **Raporlama**
  - Excel’e veri aktarma
  - Ürün,Sipariş ve Carilere Ait Raporlar
- 🔐 **Güvenlik**
  - Kullanıcı işlemlerinin loglanması
- **EKSTRA**
  - Stok ve Cari hareketleri
  - İşlem geçmişi
  - Admine özel kullanıcı ekleme ve yönetme
  

---

## 🖼️ Ana Ekran Özeti

Ana sayfada şu genel bilgiler görüntülenmektedir:
- Toplam ürün sayısı
- Toplam stok miktarı
- Kritik stoktaki ürünler
- Stoğu 0 olan ürünler
- Beklemede olan siparişler
- Onaylanan siparişler
- Toplam Satış Tutarı
- Toplam Cari Alacak Tutarı
- Toplam Cari Borç Tutarı
- Cari Sayısı

---

## 🛠️ Teknolojiler

- **Dil:** C# (.NET Framework)
- **Arayüz:** WinForms
- **Veritabanı:** SQL Server
- **Raporlama:**  Excel aktarımı
- **Geliştirme Ortamı:** Visual Studio

---

## ⚙️ Kurulum

1. **Veritabanı Kurulumu**
   - `DEPOTAKIP2` adında bir SQL Server veritabanı oluşturun.
   - Projedeki `.sql` dosyası ile tabloları ve verileri içeri aktarın.
   - ÖNEMLİ:Stok Hareketleri,Cari Hareketleri,Stoktan Ürün düşmesi gibi olaylar veritabanı scriptine triggerlar eklenmediği için yoktur

2. **Uygulama Ayarları**
   - `App.config` veya bağlantı içeren sınıf dosyalarında `SqlConnection`'ın `Data Source` kısmını kendi SQL Server adınıza göre değiştirin.

3. **Çalıştırma**
   - Visual Studio'dan projeyi açın ve `Inventra.sln` dosyasını çalıştırarak uygulamayı başlatın.
     
4. **Çoklu Kullanıcı**
   -Bu işlem ticari kullanım içindir.
---


## 📌 Geliştirici Notları

- Uygulamadaki tüm datasetleri sildim bu yüzden veritabanı işlemlerini yapsanız bile hata verecektir.Visual Studiodan kendi datasetlerinizi eklemeniz gerekir.
- Ayrıca bu benim ilk projem :)
- Triggerlar scriptte olmadığı için uygulama tam kapsamlı ve doğru olarak çalışmaz.

---

## 👨‍💻 Geliştirici

- **Ad:** Metin Can Gül  
- **İletişim:** metincangul35@gmail.com

---

## 📝 Lisans

Bu proje kişisel öğrenim ve eğitim amaçlı geliştirilmiştir. Ticari amaçla kullanılması izinsiz olarak yasaktır.

---

