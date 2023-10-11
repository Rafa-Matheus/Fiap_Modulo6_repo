using Fiap.Api.Donation1.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fiap.Api.Donation1.Services
{
    public class AuthenticationService
    {

        public static string GetToken(UsuarioModel usuarioModel)
        {
            byte[] secret = Encoding.ASCII.GetBytes("d98193f6 - 0c56 - 43e1 - 954a - 6efd41baed87");

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuarioModel.NomeUsuario),
                    new Claim(ClaimTypes.Role, usuarioModel.Regra),
                    new Claim(ClaimTypes.Email, usuarioModel.EmailUsuario)
                }),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = new SigningCredentials(
                                new SymmetricSecurityKey(secret), 
                                SecurityAlgorithms.HmacSha256Signature),
            };

            SecurityToken securityToken = handler.CreateToken(securityTokenDescriptor);

            return handler.WriteToken(securityToken);
        }
    }
}
