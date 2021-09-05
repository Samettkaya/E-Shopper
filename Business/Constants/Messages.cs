
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

        //Product

        public static string ProductAdd = "Ürün eklendi";
        public static string GetAllByCategory = "Kategoriye ait ürün listelendi";
        public static string ProductsListed = "Ürünler listelendi";

        // Kategori

        public static string CategoryAdd = "Kategori Eklendi";
        public static string GetAllCategory = "Tüm Kategoriler Listelendi";
        public static string GetByIdCategory = "Kategori Listelendi";

        //Brand
        public static string BrandGetAll = "Markalar Listelendi";
        public static string BrandAdd = "Marka eklendi";
    }
}
