# Kütüphane Yönetim Sistemi Web Uygulaması

Bu proje, basit bir Kütüphane Yönetim Sistemi web uygulaması geliştirmeyi amaçlamaktadır. Uygulama, kitaplarla ilgili temel CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirebilecek sayfalardan oluşacaktır. Ayrıca, üyelik ve rol yönetimi entegre edilecek ve admin paneli üzerinden kullanıcı yönetimi yapılacaktır.

## Bu projede şu işlevsellikler sağlanacaktır:

- **Kitap Listeleme:** Sistemde mevcut tüm kitaplar bir tablo halinde listelenecektir.
- **Kitap Detayları:** Belirli bir kitabın ayrıntılı bilgileri görüntülenebilecektir.
- **Üyelik ve Rol Yönetimi Sistemi:**  Kullanıcılar sisteme üye olabilecek, giriş yapabilecek ve çıkış yapabilecektir. Ayrıca, admin rolü olan kullanıcılar, diğer kullanıcıları yönetebilecek ve rolleri atayabilecektir.

## Teknolojiler

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Identity Framework**
- **Repository Pattern ve Unit of Work**
- **SQL Server/PostgreSQL/SQLite**

## Kitap Listeleme Sayfası

Kitap listesindeki tüm kitaplar tablo formatında görüntülenir. Her kitap, başlık, yazar, yayın yılı ve ISBN numarasına göre listelenir.

<img width="1169" alt="Screenshot 2024-12-16 at 21 37 50" src="https://github.com/user-attachments/assets/b991b5c0-55b9-4988-a037-c90e0156da25" />


## Kitap Detay Sayfası
Kitap listesindeki bir kitaba tıklandığında, kullanıcılara kitabın ayrıntılı bilgileri gösterilecektir.

<img width="745" alt="Screenshot 2024-12-16 at 21 40 55" src="https://github.com/user-attachments/assets/398ca201-d397-464c-8e69-da34540fd1fa" />


## Üyelik ve Rol Yönetimi

- Kullanıcı Yönetimi: Admin kullanıcıları, kullanıcıları ekleyebilir, güncelleyebilir ve silebilir.
- Rol Yönetimi: Admin kullanıcıları, kullanıcılara roller atayabilir veya silebilir.
- Ziyaretçi ve Üye Yönetimi: Ziyaretçiler üye olabilir, giriş yapabilir ve çıkış yapabilir.
<img width="377" alt="Screenshot 2024-12-16 at 21 40 19" src="https://github.com/user-attachments/assets/6f98f3a7-9223-4c13-a45f-d4c11778affd" />

<img width="767" alt="Screenshot 2024-12-16 at 21 37 32" src="https://github.com/user-attachments/assets/3b7cea43-e186-4572-b89f-85381e2e36a9" />
<img width="889" alt="Screenshot 2024-12-16 at 21 40 31" src="https://github.com/user-attachments/assets/833c89f2-1f94-42ac-9ce1-eb6bd32b63ca" />

