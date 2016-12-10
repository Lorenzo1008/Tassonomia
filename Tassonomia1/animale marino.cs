using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class animale_marino:pesce
    {
        public animale_marino(string nome, string tipo, string habitat, int numero)
            : base(nome, tipo, "mare", numero)
        { }
        public override string siMuove()
        {
            string c = "flush,flush";
            return c;
        }
    }
}
