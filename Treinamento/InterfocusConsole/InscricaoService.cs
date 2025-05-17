using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfocusConsole
{
    public class InscricaoService
    {
        private static List<Inscricao> list = new List<Inscricao>();

        public bool Cadastrar(Inscricao inscricao)
        {
            var valido = Validar(inscricao);
            if (valido)
            {
                list.Add(inscricao);
                return true;
            }
            return false;
        }

        public static bool Validar(Inscricao inscricao)
        {
            var context = new ValidationContext(inscricao);
            var erros = new List<ValidationResult>();
            var valido = Validator.TryValidateObject(inscricao, context, erros, true);

            foreach (var erro in erros)
            {
                Console.WriteLine($"{erro.MemberNames.First()}: {erro.ErrorMessage}");
            }

            return valido;
        }

        public List<Inscricao> Consultar() => list.ToList();

        public List<Inscricao> ConsultarPorAluno(string alunoId)
        {
            return list.Where(i => i.AlunoId == alunoId).ToList();
        }

        public List<Inscricao> ConsultarPorCurso(string cursoId)
        {
            return list.Where(i => i.CursoId == cursoId).ToList();
        }
    }
}