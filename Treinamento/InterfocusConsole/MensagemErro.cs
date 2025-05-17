<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfocusConsole
{
    class MensagemErro
    {
        public MensagemErro(string Propriedade, string Mensagem)
        {

        }
=======
﻿namespace InterfocusConsole
{
    public class MensagemErro
    {
        public MensagemErro(string propriedade,
            string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
>>>>>>> 0e8221c2a7057d5e8f229c246c3327a289f5ed89
    }
}
