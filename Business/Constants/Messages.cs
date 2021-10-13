
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
      
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";

        // Product

        public static string ProductAdd = "Ürün eklendi";
        public static string GetAllByCategory = "Kategoriye ait ürün listelendi";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductUpdate = "Ürün Güncelendi";
        public static string ProductDelete = "Ürün Silindi";

        // Categori

        public static string CategoryAdd = "Kategori Eklendi";
        public static string GetOrderDetailGet = "Tüm Kategoriler Listelendi";
        public static string GetByIdCategory = "Kategori Listelendi";
        public static string CategoryDelete = "Kategori Silindi";
        public static string CategoryUpdate = "Kategori Güncelendi";
     
        // Brand
        public static string BrandGetAll = "Markalar Listelendi";
        public static string BrandAdd = "Marka eklendi";
        public static string BrandGet ="Marka listelendi";
        public static string BrandDelete = "Marka Silindi";
        public static string BrandUpdate = "Marka Güncelendi";

        // Address
        public static string AddressAdd = "Adress Eklendi";
        public static string AddressGetAll = "Tüm Adres Listelendi";
        public static string AddressGetById = "Adres Listelendi";
        public static string AddressDelete = "Adres Silindi";
        public static string AddressUpdate = "Adres Güncelendi";


        //Users
        public static string UserRegister = "Kayıt olundu";
        public static string UserLoginNotFound = "Kullanıcı Bulunamadı";
        public static string UserLoginPasswordErrors = "Şifre Yanlış";
        public static string UserLogin = "Giriş Yapıldı";
        public static string UserAvailable = "Kullanıcı Mevcut";
        public static string TokenCreated = "Token oluşturuldu";

        public static string BasketDelete { get; internal set; }
        public static string BasketAdd { get; internal set; }
        public static string BasketGetAll { get; internal set; }
        public static string OrderAdd { get; internal set; }
        public static string OrderDelete { get; internal set; }
        public static string OrderDetailGetAll { get; internal set; }
    }
}
