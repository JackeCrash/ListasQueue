using System;
using System.Collections.Generic;

namespace ListasQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> numeros = new Queue<int>();

            foreach(int item in new int[] {10, 20, 30, 40, 50 })
            {
                numeros.Enqueue(item);
            }

            Console.WriteLine("Recorriendo cola: ");

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Quitando elemento de la cola:");

            numeros.Dequeue();

            foreach (int item in numeros) Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("Elementos de la cola = {0}", numeros.Count);

            int obj = numeros.Peek();

            Console.WriteLine("Primer objeto en cola: {0}", obj);
            Console.WriteLine();
            Console.WriteLine("numeros.Dequeue();");

            numeros.Dequeue();

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            int[] arreglo = numeros.ToArray();
            Console.WriteLine("Elementos de la cola pasados a un arreglo:");
            foreach (int item in arreglo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Vaciamos los elementos de la cola: numeros.Clear();");
            numeros.Clear();

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

        }
    }
}
