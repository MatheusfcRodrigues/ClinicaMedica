using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Médica
{
    public class Medico : Pessoa
    {
        public int Id { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
    }
}
