using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class Uccello:bipede
    {
        public Uccello(string nome, string tipo, string habitat, int numero) : base(nome, tipo, "terra/aria", numero) { }
        public override string siMuove()
        {
            string e = "fiu,fiu";
            return e;
        }
    }
}
