using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfocusConsole.Services
{
    public class CursoService
    {
        private static List<Curso> list = new List<Curso>();

        public bool Cadastrar(Curso curso)
        {
            var valido = Validar(curso);
            if (valido)
            {
                list.Add(curso);
                return true;
            }
            return false;
        }

        public static bool Validar(Curso curso)
        {
            var context = new ValidationContext(curso);
            var erros = new List<ValidationResult>();
            var valido = Validator.TryValidateObject(curso, context, erros, true);

            foreach (var erro in erros)
            {
                Console.WriteLine($"{erro.MemberNames.First()}: {erro.ErrorMessage}");
            }

            return valido;
        }

        public List<Curso> Consultar() => list.ToList();

        public Curso ConsultarPorId(string id)
        {
            return list.FirstOrDefault(c => c.Id == id);
        }

        public Curso Editar(Curso curso)
        {
            var existente = ConsultarPorId(curso.Id);
            if (existente == null) return null;

            existente.Nome = curso.Nome;
            existente.Descricao = curso.Descricao;
            return existente;
        }

        public Curso Deletar(string id)
        {
            var existente = ConsultarPorId(id);
            if (existente != null)
            {
                list.Remove(existente);
            }
            return existente;
        }
    }
}