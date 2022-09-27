# Araba Kiralama Projesi
- Proje Araba Kiralama projesidir. 
- Proje Çok katmanlı Mimari ile oluşturulmuştur.
- Ayrıca SOLID prensiplerine bağlı kalınarak oluşturulmuş bir projedir.

# Katmanlar
- Core : Projenin core katmanı evrensel işlemler için kullanılır.
- DataAccess : Projeyi veri tabanına bağlayan katmandır.
- Entities: Veri tabanındaki tablolarımız projemizde nesne olarak oluşturulmuştur. Ayrıca DTO nesneleri içerir.
- Business : Projemizin iş katmanıdır. Çeşitli iş kuralları; Veri kontrolleri, doğrulamalar ve yetkilendirme kontrolleri bu katmandadır.
- WebAPI : Projenin Restful API Katmanıdır. Kullanılan metotlar: Get, Post, Put, Delete

# Kullanılan Teknolojiler

- ASP.NET
- MSSQL
- Entity Framework
- AOP(Aspect Oriented Programming)
- Autofac
- Fluent Validation
- JWT(JSON Web Token)
- Restful API
- Cross Cutting Concerns
- Cashing, Validation, Transaction, Performance Aspects
