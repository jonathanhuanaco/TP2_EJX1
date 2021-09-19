using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    internal class Escopeta:Arma
    {
        public Escopeta()
        {
            nombre = "Escopeta";
        }
        public override string Disparar()
        {
            return "pááá!...";
        }
    }
}
