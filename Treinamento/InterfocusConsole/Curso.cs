using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfocusConsole
{
    public class Curso
    {
        [Required, StringLength(10, MinimumLength = 3)]
        public string Id { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; private set; } = DateTime.Now;

        public virtual string GetPrintMessage()
        {
            return $"{Id} - {Nome}";
        }
    }
}