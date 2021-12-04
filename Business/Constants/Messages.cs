
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

        //Baskets
        public static string BasketDelete = "Sepet Silindi";
        public static string BasketAdd = "Sepete Eklendi";
        public static string BasketGetAll = "Sepet Listelendi";

        //Order
        public static string OrderAdd = "Sipariş Verildi";
        public static string OrderDelete = "Sipariş İptal Edildi!";
        public static string OrderDetailGetAll = "";

        //SubCategories
        public static string SubCategoryAdd = "Alt Kategori Eklendi";
        public static string SubCategoryDelete = "Alt Kategori Silindi";
        public static string SubCategoryUpdate = "Alt Kategori Güncelendi";
        public static string SubCategoryGetAll = "Tüm Alt Kategoriler Listelendi";
        public static string GetByIdSubCategory = "Alt Kategoi Listelendi";

        //ASubCategories
        public static string ASubCategoryAdd = "En Alt Kategori Eklendi";
        public static string ASubCategoryDelete = "En Alt Kategori Silindi";
        public static string ASubCategoryGetAll = "Tüm En Alt Kategori Listelendi";
        public static string ASubCategoryGetById = "En Alt Kategri Listelendi";
        public static string ASubCategoryUpdate = "En Alt Kategori Güncelendi";

        //District
        public static string DistrictAdd = "İlçe Eklendi";
        public static string DistrictDelete = "İlçe Silindi";
        public static string DistrictGetAll = "Tüm İlçe Listelendi";
        public static string DistrictGetById = "İlçe Listelendi";
        public static string DistrictUpdate = "İlçe Güncelendi";

        //Neighbourhood
        public static string NeighbourhoodAdd = "Mahalle Eklendi";
        public static string NeighbourhoodDelete = "Mahalle Silindi";
        public static string NeighbourhoodGetAll = "Tüm Mahalle Listelendi";
        public static string NeighbourhoodGetById = "Mahalle Listelendi";
        public static string NeighbourhoodUpdate = "Mahalle Güncelendi";

        //City
        public static string CityAdd = "İlçe Eklendi";
        public static string CityDelete = "İlçe Silindi";
        public static string CityGetAll = "Tüm İlçe Listelendi";
        public static string CityGetByID = "İlçe Listelendi";
        public static string CityUpdate = "İlçe Güncellendi";
    }
}
