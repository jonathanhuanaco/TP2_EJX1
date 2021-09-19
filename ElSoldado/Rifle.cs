using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    internal class Rifle:Arma
    {
        public Rifle()
        {
            nombre = "Rifle";
        }
        public override string Disparar()
        {
            return "pum pum pum!...";
        }
    }
    
}
