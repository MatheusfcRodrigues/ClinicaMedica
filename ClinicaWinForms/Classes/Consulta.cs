using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Médica
{
    public class Consulta
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataHora { get; set; }
    }
}
