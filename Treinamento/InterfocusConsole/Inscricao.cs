using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfocusConsole
{
    public class Inscricao
    {
        [Required]
        public string AlunoId { get; set; }

        [Required]
        public string CursoId { get; set; }

        public DateTime DataInscricao { get; private set; } = DateTime.Now;
    }
}
