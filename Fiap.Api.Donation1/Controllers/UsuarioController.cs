using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

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
        public ActionResult<UsuarioModel> Login([FromBody] UsuarioModel usuarioModel) 
        {
            var usuario = usuarioRepository
                .FindByEmailAndSenha(usuarioModel.EmailUsuario, usuarioModel.Senha);

            if (usuario != null) return Ok();
            else return NotFound();

            //return usuario;
        }

        [HttpGet]
        public async Task<ActionResult<IList<UsuarioModel>>> Get()
        {
            var usuarios = await usuarioRepository.FindAll();

            if (usuarios == null || usuarios.Count == 0) return NoContent();
            else return Ok(usuarios);

            //return usuarios;
        }

        [HttpGet("{id:int}")]
        public ActionResult<UsuarioModel> Get(int id)
        {
            var usuario = usuarioRepository.FindById(id);

            if (usuario == null || usuario.UsuarioId == 0) return NotFound();
            else return Ok(usuario);

            //return usuarioRepository.FindById(id);
        }


        #region Método POST - Codificação simplificada
        /*
        [HttpPost]
        public int Post([FromBody] UsuarioModel usuarioModel)
        {
            var retorno = usuarioRepository.Insert(usuarioModel);
            return retorno;
        }*/

        #endregion


        #region Método POST - Codificação mais elaborada
        
        [HttpPost]
        public ActionResult<UsuarioModel> Post([FromBody] UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            // var retorno = usuarioRepository.Insert(usuarioModel); // Remover/Comentar linha
            // return Created("",retorno); // Remover/Comentar linha

            try
            {

                usuarioRepository.Insert(usuarioModel);

                var url = Request.GetEncodedUrl().EndsWith("/") ?
                                                Request.GetEncodedUrl() :
                                                Request.GetEncodedUrl() + "/";

                var location = new Uri(url + usuarioModel.UsuarioId);

                return Created(location, usuarioModel);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        #endregion


        [HttpPut("{id:int}")]
        public ActionResult<UsuarioModel> Put([FromRoute] int id, [FromBody] UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id != usuarioModel.UsuarioId) return NotFound();

            usuarioRepository.Update(usuarioModel);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public ActionResult<int> Delete([FromRoute] int id)
        {
            if (id == 0) return BadRequest();

            var usuarioModel = usuarioRepository.FindById(id);

            if (usuarioModel == null) return NotFound();
            
            usuarioRepository.Delete(id);
            return NoContent();
            
        }

    }
}
