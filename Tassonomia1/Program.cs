using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia1
{
    class Program
    {
        static void Main(string[] args)
        {
            cavallo c = new cavallo();
            uomo u = new uomo();
            Corvo a = new Corvo();
            Tonno t = new Tonno();
            salmone s = new salmone();
            Pinguino p = new Pinguino();
            c.Riepilogo();
            Console.WriteLine(c.siMuove()) ;
            u.Riepilogo();
            Console.WriteLine(u.siMuove());
            a.Riepilogo();
            Console.WriteLine(a.siMuove());
            t.Riepilogo();
            Console.WriteLine(t.siMuove());
            s.Riepilogo();
            Console.WriteLine(s.siMuove());
            p.Riepilogo();
            Console.WriteLine(p.siMuove());
            Console.ReadLine();
        }
    }
}
