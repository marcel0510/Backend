using Microsoft.IdentityModel.Tokens;
using Model.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebAPI.Secutiry
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _ssKey;

        public TokenService(IConfiguration configuration)
        {
            _ssKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TknKey"]));
        }
        public string GetToken(User user)
        {
            var claims = new List<Claim> {

                new Claim(JwtRegisteredClaimNames.NameId, user.Email)

            };

            var credentials = new SigningCredentials(_ssKey, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

       
    }
}
