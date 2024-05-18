using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Transactions;

namespace WebApiJwt.Models
{
    public class CreatToken
    {
        public string Tokencreat() 
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key= new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost",notBefore:DateTime.Now,expires:DateTime.Now.AddSeconds(15),signingCredentials:credentials);
           JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
         return  handler.WriteToken(token);


        }
        public string ToeknCreatAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials signingCredentials =new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,"admin"),
                new Claim(ClaimTypes.Role,"visitor"),
            };
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddSeconds(30), signingCredentials: signingCredentials, claims: claims);

            JwtSecurityTokenHandler handler =new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }
    }
}
