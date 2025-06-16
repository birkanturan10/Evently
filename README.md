# 🎫 Evently

Evently, kullanıcıların etkinlikleri (event) listeleyebileceği, yeni etkinlikler ekleyip silebileceği basit bir ASP.NET Core MVC uygulamasıdır. Uygulama katmanlı mimari kullanılarak oluşturulmuştur.

## 🚀 Projeyi Çalıştırmak İçin

Bu projeyi çalıştırmak isteyen bir geliştirici aşağıdaki adımları izlemelidir:

1. **Veritabanı Bağlantısı:**
   - `appsettings.json` veya `Program.cs` içindeki bağlantı cümlesi şuna benzemelidir:
     ```
     Server=LAPTOP-G13T04V9\SQLEXPRESS;Database=EventlyDb;Trusted_Connection=True;TrustServerCertificate=True;
     ```
   - Kendi bilgisayar isminize göre `Server=` kısmını düzenleyin.

2. **Migration Oluşturun ve Veritabanını Güncelleyin:**
   - Paket Yöneticisi Konsolu'nda sırasıyla şu komutları çalıştırın:
     ```
     Add-Migration InitialCreate
     Update-Database
     ```

3. **Kategori Verisi Girişi:**
   - Uygulama şu anda kategorileri SQL Server Management Studio (SSMS) üzerinden manuel olarak alır.
   - `Category` tablosuna en az 1 tane kategori girilmelidir. Aksi halde etkinlik ekleme sırasında hata oluşur.
   - Örnek sorgu:
     ```sql
     INSERT INTO Category (Name) VALUES ('Konferans')
     ```

4. **Projeyi Çalıştırın:**
   - `UI` katmanını `Startup Project` olarak ayarlayıp uygulamayı çalıştırın.

## 💡 Neler Yapılabilir?

- Etkinlikleri listeleyebilirsiniz.
- Yeni bir etkinlik ekleyebilirsiniz.
- Eklediğiniz etkinlikleri silebilirsiniz.

> Güncelleme (edit) özelliği test aşamasında karmaşa oluşturduğu için son sürümde çıkarılmıştır.

---

## 🧰 Kullanılan Teknolojiler ve Yapılar

- ASP.NET Core MVC (.NET 8.0)
- Entity Framework Core
- Katmanlı Mimari (Layered Architecture):
  - **EntityLayer:** Sınıfların (veri modellerinin) tanımlandığı katman.
  - **DataAccessLayer:** Veritabanı işlemlerinin gerçekleştiği katman.
  - **BusinessLayer:** İş mantığının yer aldığı katman.
  - **UI (PresentationLayer):** Kullanıcı arayüzü katmanı (MVC).
- SQL Server (LocalDb / SQLEXPRESS)
- Repository Design Pattern (Generic Repository ile)

---
