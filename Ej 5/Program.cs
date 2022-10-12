using System;

namespace Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorial=1;
            int numero;

            Console.WriteLine("Ingrese el primero numero a factorizar: ");
            numero=int.Parse(Console.ReadLine());

            for (int i=1; i<=numero; i++){
                factorial = factorial*i;
            }
            Console.WriteLine("El resultado es: " + factorial);
            Console.ReadLine();
           
        }
    }
}
