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
            if (a.Top < b.Top && !a.isEmpty() || b.isEmpty())
            {
                Console.WriteLine("Movemos el disco de tamaño " + a.Top + " encima del disco de tamaño " + b.Top);
                b.push(a.pop());
            }
            else
            {
                Console.WriteLine("Movemos el disco de tamaño " + b.Top + " encima del disco de tamaño " + a.Top);

                a.push(b.pop());

            }
        }
        public int iterativo(int n,Pila ini, Pila aux, Pila fin)
        {
            int m = 0;
            if (n % 2 == 1)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    if (fin.Size == n) { 
                        break; 
                    }
                    mover_disco(ini, aux);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(aux, fin);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                }
            }
            else if (n % 2 == 0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(ini, fin);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(aux, fin);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                }
            }
            return m;
        }
    }
}
