using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarNameInvalid = "Geçersiz isim!";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarListed = "Araba gösterildi.";

        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string GetCustomer = "Müşteri gösterildi.";

        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserListed = "Kullanıcı getirildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string UserRegistered = "Kullanıcı kaydı başarılı";

        public static string RentalAdded = "Kiralama işlemi yapıldı.";
        public static string GetRental = "Kiralama işlemi gösterildi.";
        public static string RentalsListed = "Tüm kiralama işlemleri listelendi";

        public static string CarImagesListed = "Arabaya ait resimler listelendi.";
        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImageUpdated = "Araba resmi güncellendi.";
        public static string CarImageDeleted = "Araba resmi silindi.";
        public static string CarImageNotFound = "Araba resmi bulunamadı.";

        public static string MaintenanceTime = "Sistem şuanda bakımda... Lütfen daha sonra tekrar deneyiniz...";
        
        public static string PasswordError = "Hatalı parola";
        public static string SuccessfulLogin = "Giriş başarılı";
        
    }
}
