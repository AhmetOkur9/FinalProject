using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string UnitPriceInvalid = "Ürüne bu fiyatı veremezsiniz";
        public static string ProductCountOfCategoryError = "15'den fazla ürün ekleyemezsiniz.";
        public static string ProductNameAlreadyExists = "Aynı isimden ürün mevcut.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered ="1";
        public static string UserNotFound = "2";
        public static string PasswordError = "3";
        public static string SuccessfulLogin = "4";
        public static string UserAlreadyExists = "5";
        public static string AccessTokenCreated = "6";
    }
}
