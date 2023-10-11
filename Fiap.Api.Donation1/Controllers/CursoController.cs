using Fiap.Api.Donation1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Fiap.Api.Donation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private static string endpoint = "https://5cb544bd07f233001424ceb8.mockapi.io/fiap/curso";

        private readonly HttpClient httpClient;

        public CursoController()
        {
            httpClient = new HttpClient();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoModel>> GetById(int id)
        {
            var resposta = await httpClient.GetAsync($"{endpoint}/{id}");

            if(resposta.IsSuccessStatusCode) 
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<CursoModel>(conteudoJson);

                return Ok(curso);

            } else
            {
                return NoContent();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<CursoModel>>> Get()
        {
            var resposta = await httpClient.GetAsync(endpoint);

            if(resposta.IsSuccessStatusCode) 
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<CursoModel>>(conteudoJson);

                return Ok(cursos);

            } else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(CursoModel cursoModel)
        {
            var conteudoJson = JsonConvert.SerializeObject(cursoModel);
            var conteudoJsonString = new StringContent(conteudoJson, System.Text.Encoding.UTF8, "application/json");
            
            var resposta = await httpClient.PostAsync(endpoint, conteudoJsonString);

            if(resposta.IsSuccessStatusCode)
            {
                var respostaSucesso = await resposta.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<CursoModel>(respostaSucesso);

                return Ok(cursoModel.Id);
            } else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<int>> Put([FromRoute]int id, CursoModel cursoModel)
        {
            var conteudoJson = JsonConvert.SerializeObject(cursoModel);
            var conteudoJsonString = new StringContent(conteudoJson, System.Text.Encoding.UTF8, "application/json");

            var resposta = await httpClient.PostAsync($"{endpoint}/{id}", conteudoJsonString);

            if (resposta.IsSuccessStatusCode)
            {
                var respostaSucesso = await resposta.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<CursoModel>(respostaSucesso);

                return Ok(cursoModel.Id);
            }
            else
            {
                return BadRequest();
            }
        }

        //[HttpDelete("{id}")]
        //public async Task<ActionResult>
    }
}
