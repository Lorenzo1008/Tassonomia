using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    public abstract class animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;
        public animale(string nome,string tipo,string habitat,int numero)
        {
            nomeAnimale=nome;
            tipoAnimale=tipo;
            this.habitat=habitat;
            numeroZampe = numero;
        }
        public abstract string siMuove();

        public void Riepilogo()
        {
            Console.WriteLine(nomeAnimale);
            Console.WriteLine(tipoAnimale);
            Console.WriteLine(habitat);
            Console.WriteLine(numeroZampe);
        }
    }
}
