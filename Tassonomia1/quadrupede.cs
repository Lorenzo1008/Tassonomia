using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class quadrupede: animale_terrestre
    {
        public quadrupede(string nome, string tipo, string habitat, int numero) : base(nome, tipo, habitat, 4) { }
        public override string siMuove()
        {
            string a = "clop,cloppette";
            return  a ;
        }
    }
}
