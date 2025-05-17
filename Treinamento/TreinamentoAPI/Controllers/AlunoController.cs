using InterfocusConsole;
<<<<<<< HEAD
using InterfocusConsole.Services;
=======
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
using Microsoft.AspNetCore.Mvc;

namespace TreinamentoAPI.Controllers
{
<<<<<<< HEAD
    [Route("api/Aluno")]
    public class AlunoController: ControllerBase
    {
        public AlunoController()
        {
=======
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService servico;

        public AlunoController(AlunoService servico)
        {
            this.servico = servico;
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
        }

        [HttpGet]
        public IActionResult Get()
        {
<<<<<<< HEAD
            var servico = new AlunoService();
=======
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
            return Ok(servico.Consultar());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Aluno aluno)
        {
<<<<<<< HEAD
            var servico = new AlunoService();
            if (servico.Cadastrar(aluno))
            {
                return Ok(aluno);
            }
            else
            {
                return BadRequest("Erro ao cadastrar aluno");
            }
        }

        [HttpPut("{codigo}")]
        public IActionResult Put([FromBody] Aluno aluno)
        {
            var servico = new AlunoService();
=======
            // AlunoService, AlunoBusiness
            // controllers: camada de acesso
            // services: camada de negócio
            // repositories: camada de dados
            if (servico.Cadastrar(aluno, out List<MensagemErro> erros))
            {
                return Ok(aluno);
            }
            return UnprocessableEntity(erros);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Aluno aluno)
        {
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
            var resultado = servico.Editar(aluno);
            if (resultado == null)
            {
                return NotFound();
            }
<<<<<<< HEAD

            return Ok(resultado);
        }

        [HttpDelete]
        public IActionResult Delete(string Codigo)
        {
            var servico = new AlunoService();
            var resultado = servico.Deletar(Codigo);
=======
            return Ok(resultado);
        }

        [HttpDelete("{codigo}")]
        public IActionResult Delete(string codigo)
        {
            var resultado = servico.Deletar(codigo);
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
            if (resultado == null)
            {
                return NotFound();
            }
<<<<<<< HEAD

            return Ok(resultado);
        }
    }
}
=======
            return Ok(resultado);
        }
    }
}
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
