# ApiProjeKampi

Bu proje, **ASP.NET Core Web API** ve **ASP.NET Core MVC (WebUI)** kullanılarak geliştirilmiş çok katmanlı bir uygulamadır.  
Backend tarafında RESTful API mimarisi, frontend tarafında ise MVC yapısı kullanılmıştır.

---
## 🍽 Proje Konusu

Proje; bir restoranın temel ihtiyaçlarını karşılayacak şekilde tasarlanmıştır.  
Restoran menüsü, ürünler ve kategoriler **Web API** üzerinden yönetilmektedir.  

Ayrıca sistem içerisinde:
- 📅 **Rezervasyon yönetimi**
- 👨‍🍳 **Şefler ve ekip tanıtımı**
- 🖼 **Restoran galeri alanı**
- 📊 **Yönetici (Admin) Dashboard paneli**

bulunmaktadır.

**WebUI** katmanı, tüm bu verileri **RESTful Web API** üzerinden tüketerek kullanıcıya sunar.

---

## 🧱 Proje Yapısı

Solution iki ana projeden oluşmaktadır:

ApiProjeKampi
├── ApiProjeKampi.WebApi
│ ├── Controllers
│ ├── Context
│ ├── Entities
│ ├── Dtos
│ ├── Mapping
│ ├── ValidationRules
│ ├── Migrations
│ ├── appsettings.json
│ └── Program.cs
│
├── ApiProjeKampi.WebUI
│ ├── Controllers
│ ├── Views
│ ├── ViewComponents
│ ├── Models
│ ├── Dtos
│ ├── wwwroot
│ ├── Requirements
│ ├── appsettings.json
│ └── Program.cs


---

## 🔧 ApiProjeKampi.WebApi

Uygulamanın backend (API) katmanıdır.

### İçerik:
- **Controllers** → API endpoint’leri
- **Context** → Entity Framework DbContext
- **Entities** → Veritabanı tabloları
- **Dtos** → Veri transfer nesneleri
- **Mapping** → AutoMapper profilleri
- **ValidationRules** → FluentValidation kuralları
- **Migrations** → EF Core migration dosyaları

### Kullanılan Teknolojiler:
- ASP.NET Core Web API
- Entity Framework Core
- MSSQL Server
- AutoMapper
- FluentValidation

---

## 🖥️ ApiProjeKampi.WebUI

Uygulamanın kullanıcı arayüzü (MVC) katmanıdır.

### İçerik:
- **Controllers** → Sayfa yönlendirmeleri
- **Views** → Razor View dosyaları
- **ViewComponents** → Tekrar kullanılabilir bileşenler
- **Dtos** → API ile veri alışverişi
- **Models** → View modelleri
- **wwwroot** → CSS, JS ve statik dosyalar

WebUI, backend API’den aldığı veriler ile sayfaları dinamik olarak oluşturmaktadır.

---

## 🤖 AI Menü Durumu

Projede AI menüsü için altyapı hazırlanmıştır.  
Ancak **API anahtarı eklenmediği için** şu anda aktif değildir.

> **Bilgilendirme:**  
> AI Menüsü şu anda devre dışı (API anahtarı eklenmemiştir).

---

## 🚀 Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullaniciAdi/ApiProjeKampi.git
2. appsettings.json dosyasında veritabanı bağlantısını güncelleyin.

3. Migration işlemlerini uygulayın: Update-Database
4. Önce ApiProjeKampi.WebApi, ardından ApiProjeKampi.WebUI projelerini çalıştırın.
