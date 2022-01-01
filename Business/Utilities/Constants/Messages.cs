using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Utilities.Strings
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanici kaydoldu";

        public static string UserNotFound = "Kullanici bulunamadı";

        public static string PasswordError = "Parola Hatali";

        public static string SuccessfulLogin = "Giris Basarili";

        public static string AccessTokenCreated = "Erisim Tokeni olusturuldu";

        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
    }
}
