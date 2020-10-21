using JwtWebApi.Entity.Interfaces;

namespace JwtWebApi.Entity.Token
{
    public class JwtAccessToken : IToken
    {
        public string Token { get; set; }
    }
}
