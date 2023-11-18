# Film Katalogu Uygulaması

Bu proje, film katalogu yönetimi için bir API ve tüketici proje içermektedir. API, Onion mimarisi kullanılarak geliştirilmiştir ve CRUD işlemleri için Automapper ve Fluent Validation kütüphaneleri entegre edilmiştir.

## Projeyi Başlatma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1. **API'yi Başlatma:**
   - `FilmCatalog.API` projesini başlatın.
   - API, varsayılan olarak `https://localhost:7096` adresinde çalışacaktır.

2. **Consumer Projesini Başlatma:**
   - `FilmCatalog.UI` projesini başlatın.
   - Consumer projesi, varsayılan olarak `https://localhost:7123` adresinde çalışacaktır.

3. **Veritabanı Bağlantısı:**
   - Projede kullanılan veritabanı bağlantı ayarlarını kontrol edin ve gerekirse düzenleyin.

## API Endpoints

API, aşağıdaki temel CRUD operasyonlarını destekler:

- **Film İşlemleri:**
  - `GET /api/Film`: Tüm filmleri getirir.
  - `GET /api/Film/{id}`: Belirli bir filmi getirir.
  - `POST /api/Film`: Yeni film ekler.
  - `PUT /api/Film/{id}`: Belirli bir filmi günceller.
  - `DELETE /api/Film/{id}`: Belirli bir filmi siler.

- **Kategori İşlemleri:**
  - `GET /api/Category`: Tüm kategorileri getirir.
  - `GET /api/Category/{id}`: Belirli bir kategoriyi getirir.
  - `POST /api/Category`: Yeni kategori ekler.
  - `PUT /api/Category/{id}`: Belirli bir kategoriyi günceller.
  - `DELETE /api/Category/{id}`: Belirli bir kategoriyi siler.

- **Aktör İşlemleri:**
  - `GET /api/Actor`: Tüm aktörleri getirir.
  - `GET /api/Actor/{id}`: Belirli bir aktörü getirir.
  - `POST /api/Actor`: Yeni aktör ekler.
  - `PUT /api/Actor/{id}`: Belirli bir aktörü günceller.
  - `DELETE /api/Actor/{id}`: Belirli bir aktörü siler.

## Teknolojiler ve Kullanılan Kütüphaneler

- ASP.NET Core 6.0
- Entity Framework Core
- HTML, CSS, Bootstrap
- SQL Server
- AutoMapper
- Fluent Validation
- ASP.NET Core Web API
  

## Kurulum ve Çalıştırma

1. Depoyu bilgisayarınıza klonlayın.
2. SQL Server üzerinde bir veritabanı oluşturun.
3. appsettings.json dosyasında veritabanı bağlantı dizesini güncelleyin.
4. `dotnet ef database update` komutunu çalıştırarak veritabanı tablolarını oluşturun.
5. Projeyi çalıştırın ve web uygulamasını tarayıcınızda görüntüleyin.
