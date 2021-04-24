using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
class Pila
    {
        private List<Disco> elementos = new List<Disco>();

        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos {
            get { return elementos; }
            set { elementos = value; }
        }


        public Pila()
        {
            Size = 0;
            Top = 0;
        }

        public Pila(List<Disco> discos)
        {
            Elementos = discos;
            Size = Elementos.Count();
            Top = Elementos[Size - 1].Valor;
        }



        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }
        public Disco pop()
        {
            Disco aux = null;
            if (Size != 0)
            {      
                aux = Elementos[Size-1];
                Elementos.RemoveAt(Size-1);
                Size--;
                if (Size == 0)){
                    Top = 0;
                }
                else {
                    Top = Elementos[Size - 1].Valor;
                }
            }
            return aux;
        }
        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }
    }
}
