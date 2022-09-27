using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //sisteme girebilmek için elimizde olan key bir credential'dır.
        //web api json web token'ı doğrulamak zorunda - hangi anahtar ve algoritma ile
        //web api appsetings.json dosyasına bak
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
            //1 tane hashing işlemi yapacaksın anahtar olarak bu security key'i, şifreleme olarak da güvenlik algoritmalarından bunu kullan.
        }
    }
}
