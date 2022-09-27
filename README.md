#Araba Kiralama Projesi

Uygulama geliştirme sürecinde cok katmanli mimari kullanılmıştır ve SOLID kurallarına bağlı kalınmıştır.

#Katmanalar
-Core : Projenin core katmanı evrensel işlemler için kullanılır.
-DataAccess : Projeyi Veritabanına bağlayan katmandır.
-Entities: Veritabanındaki tablolarımız projemizde nesne olarak oluşturulmuştur. Ayrıca DTO nesneleri içerir.
-Business : Projemizin iş katmanıdır. Çeşitli iş kuralları; Veri kontrolleri, doğrulamalar ve yetkilendirme kontrolleri
-WebAPI : Projenin Restful API Katmanıdır. Bilinen metotlar: Get, Post, Put, Delete

#Kullanılan Teknolojiler

-ASP.NET
-Entity Framework
-Autofac
-Fluent Validation
-JWT(JSON Web Token)
-Cashing, Validation, Transaction, Performance Aspects
