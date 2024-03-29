﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductRemoved = "Ürün silindi";
        public static string ProductInvalid = "Ürün eklenemedi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string UnsupportedFileType = "Desteklenmeyen dosya türü";
        public static string TheCarHasNotBeenDeliveredYet = "Araba henüz teslim edilmemiş";
        public static string TheImageLimitForThisCarHasBeenExceed = "Bu araba için daha fazla resim ekleyemezsin";
        public static string ImageAdded = "Resim eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExist = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
