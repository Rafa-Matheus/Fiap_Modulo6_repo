using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository _usuarioRepository)
        {
            usuarioRepository = _usuarioRepository;
        }

        [HttpPost] // Para proteger os dados sensíveis do usuário
        [Route("Login")]
        public UsuarioModel Login([FromBody] UsuarioModel usuarioModel) 
        {
            var usuario = usuarioRepository
                .FindByEmailAndSenha(usuarioModel.EmailUsuario, usuarioModel.Senha);

            return usuario;
        }

        [HttpGet]
        public IList<UsuarioModel> Get()
        {
            var usuarios = usuarioRepository.FindAll();

            return usuarios;
        }
    }
}
