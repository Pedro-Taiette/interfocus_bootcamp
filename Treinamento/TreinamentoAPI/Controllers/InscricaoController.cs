using InterfocusConsole;
using Microsoft.AspNetCore.Mvc;

namespace TreinamentoAPI.Controllers
{
    [Route("api/Inscricao")]
    public class InscricaoController : ControllerBase
    {
        private InscricaoService servico = new InscricaoService();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(servico.Consultar());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Inscricao inscricao)
        {
            if (servico.Cadastrar(inscricao))
                return Ok(inscricao);
            return BadRequest("Erro ao cadastrar inscrição");
        }

        [HttpGet("aluno/{alunoId}")]
        public IActionResult GetByAluno(string alunoId)
        {
            return Ok(servico.ConsultarPorAluno(alunoId));
        }

        [HttpGet("curso/{cursoId}")]
        public IActionResult GetByCurso(string cursoId)
        {
            return Ok(servico.ConsultarPorCurso(cursoId));
        }
    }
}
