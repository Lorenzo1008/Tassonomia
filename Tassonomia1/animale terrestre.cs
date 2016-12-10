using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class animale_terrestre:animale
    {
        public animale_terrestre(string nome, string tipo, string habitat, int numero)
            : base(nome, "animale terrestre", habitat, numero)
        { }
    }
}
