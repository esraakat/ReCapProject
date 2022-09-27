# Araba Kiralama Projesi
Bu proje Araba Kiralama Sistemi projesidir. Proje hem Çok katmanlı Mimari kullanılmıştır hem de SOLID prensiplerine bağlı kalınarak oluşturulmuş bir projedir.

# Katmanlar
- Core : Projenin core katmanı evrensel işlemler için kullanılır.
- DataAccess : Projeyi veri tabanına bağlayan katmandır.
- Entities: Veri tabanındaki tablolarımız projemizde nesne olarak oluşturulmuştur. Ayrıca DTO nesneleri içerir.
- Business : Projemizin iş katmanıdır. Çeşitli iş kuralları; Veri kontrolleri, doğrulamalar ve yetkilendirme kontrolleri. 
- WebAPI : Projenin Restful API Katmanıdır. Kullanılan metotlar: Get, Post, Put, Delete

# Kullanılan Teknolojiler

- ASP.NET
- Entity Framework
- AOP(Aspect Oriented Programming)
- Autofac
- Fluent Validation
- JWT(JSON Web Token)
- Restful API
- Cross Cutting Concerns
- Cashing, Validation, Transaction, Performance Aspects
