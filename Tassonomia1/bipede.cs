using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class bipede: animale_terrestre
    {
        public bipede(string nome, string tipo, string habitat, int numero) : base(nome, tipo, habitat, 2) { }
        public override string siMuove()
        {
            string d = "tonf,tonf";
            return d;
        }
    }
}
