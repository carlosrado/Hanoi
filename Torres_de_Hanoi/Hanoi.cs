using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int m = 0;

        public void mover_disco(Pila a, Pila b)
        {
            //si a < b, muevo de a hacia b. En caso contrario, de b hacia a.
            if(a.Top < b.Top && !a.isEmpty() || b.isEmpty())
            {
                b.push(a.pop());
                Console.Write("Movemos el disco de tamaño: " + a.Top + "encima del disco de tamaño" + b.Top);
            } else
            {
                a.push(b.pop());
                Console.Write("Movemos el disco de tamaño: " + b.Top + "encima del disco de tamaño" + a.Top);

            }
        }
        public int iterativo(Pila ini, Pila aux, Pila fin)
        {
            int m = 0;
            if (n % 2 == 1)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(aux, fin);
                    m++;
                }
            } else if (n % 2 == 0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(aux, fin);
                    m++;
                }
            }
            return m;
        }
}
