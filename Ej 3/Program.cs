using System;

namespace Ej_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float tempmin=0f, tempmax=0f, tempdiaria=0f;
            int diamin=0, diamax=0;

            Console.WriteLine("Registro de temperatura diaria");

            calcularTemp();

            Console.WriteLine("La temperatura maxima es " + tempmax + " En el dia " + diamax);
            Console.WriteLine("La temperatura minima es " + tempmin + " En el dia " + diamin);
        }
        static void calcularTemp(float tempmin=0f, float tempmax=0f, float tempdiaria=0f, int diamax=0, int diamin=0)
        {
            for(int i =1; i < 8; i++)
            { 
                Console.WriteLine("Ingrese la temperatura del dia N° " + i);
                tempdiaria = Convert.ToInt32(Console.ReadLine());

                if (tempdiaria > tempmax)
                {
                 tempmax=tempdiaria;
                 diamax=i;   
                }
                if (tempdiaria < tempmin)
                {
                    tempmin=tempdiaria;
                    diamin=i;
                }
              
            }
        }
    }
}