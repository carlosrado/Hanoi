using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disco> lista = new List<Disco>();
            lista.Add(new Disco (5));
            lista.Add(new Disco (4));
            lista.Add(new Disco (1));
            Pila ini = new Pila(lista);
            Pila aux = new Pila();
            Pila fin = new Pila();
            Hanoi hanoi = new Hanoi();
            int res = hanoi.iterativo(ini.Size, ini, aux, fin);
            Console.WriteLine("El numero total de movimientos es: "+res);
            Console.ReadKey();
        }
    }
}
