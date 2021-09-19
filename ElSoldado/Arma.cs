using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    internal abstract class Arma
    {
        protected String nombre ="";
        public string Nombre { get => nombre; }
        public abstract string Disparar();
    }
}
