
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TechnorexNotes.Shared
{
    public static class JwtTokenGenerator
    {
        public static string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Keys.SecretKey));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim("userName",user.UserName)
            };

            var token = new JwtSecurityToken(expires:DateTime.Now.AddMinutes(10), signingCredentials:credentials, claims: claims);
            
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
