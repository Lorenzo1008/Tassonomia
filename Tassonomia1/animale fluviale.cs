using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class animale_fluviale:pesce
    {
        public animale_fluviale(string nome, string tipo, string habitat, int numero)
            : base(nome, tipo, "fiume", numero)
            
        { }
        public override string siMuove()
        {
            string b = "splash, splash";
            return b;
        }
    }
}
