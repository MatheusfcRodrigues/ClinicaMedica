using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Médica
{
    using System;

    public class Paciente : Pessoa
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }

}
