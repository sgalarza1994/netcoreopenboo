using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims
namespace CursoWebApi6.Helper
{
    public static class JwetHelper
    {
        public static IEnumerable<Claim> GetClaims(this UserTokens userAccount, Guid id)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("", userAccount.Id.ToString()),
                new Claim(ClaimTypes.Name,userAccount.UserName),
                new Claim(ClaimTypes.Email,userAccount.Email),
                new Claim(ClaimTypes.Expiration, DateTime.UtcNow.AddDays(1).ToString("MMMM ddd dd yyyy HH:mm:ss tt"))
            };
            if(userAccount.UserName  == "Admin")
            {
                claims.Add(new Claim())
            }

        }
    }
}
