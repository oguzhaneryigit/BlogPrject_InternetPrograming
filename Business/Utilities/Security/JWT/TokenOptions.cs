namespace Business.Utilities.Security.JWT
{
    public class TokenOptions
    {//json içindeki token opetionsu ve değerlerini tutar
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}