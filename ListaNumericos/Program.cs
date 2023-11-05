using System;
using System.Collections.Generic;

namespace ListaNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                numeros.Add(i);
            }

            Console.WriteLine("Lista de números de 0 a 100:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine(); 

            Console.WriteLine("Números ímpares:");
            foreach (int numero in numeros)
            {
                if (numero % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
            }
        }
    }
}
