using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class program
    {
        static void Main(string[] args)
        {
            // Stack: El ultimo que entra es el primero en salir
            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(2, 5));
            puntos.Push(new CPunto(1, 6));
            puntos.Push(new CPunto(4, 9));
            puntos.Push(new CPunto(3, 7));
            puntos.Push(new CPunto(6, 8));

            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("-----------------------------------------------------");

            // Peek: Permite observar el primer elemento sin sacarlo
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("------------------------------------------------------");

            // Pop: saca el elemento que esta hasta arriba
            Console.WriteLine("Pop {0}", puntos.Pop());

            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("------------------------------------------------------");

            // de nuevo un peek para ver quien es el que quedo arriba tras el Pop
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("------------------------------------------------------");




        }

    }

}
