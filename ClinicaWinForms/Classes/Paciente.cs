using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Médica
{
    public class Paciente : Pessoa
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }

}
