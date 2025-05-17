using InterfocusConsole;
using Microsoft.AspNetCore.Mvc;

namespace TreinamentoAPI.Controllers
{
    [Route("api/Curso")]
    public class CursoController : ControllerBase
    {
        private CursoService servico = new CursoService();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(servico.Consultar());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Curso curso)
        {
            if (servico.Cadastrar(curso))
                return Ok(curso);
            return BadRequest("Erro ao cadastrar curso");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Curso curso)
        {
            var resultado = servico.Editar(curso);
            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var resultado = servico.Deletar(id);
            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }
    }
}
