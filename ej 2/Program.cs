using System;

namespace ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int publico=0, privado=0, cantAlum=0;
            string colegio= "e";
            float porcentajepub=0f;
            float porcentajepriv=0f;

            Console.WriteLine("Bienvenido al Sistema de Alumnos de Colegios Publicos y Privados");
            Console.WriteLine("Apriete una tecla para continuar");

            Console.ReadLine();
            Console.Clear();

            while(true)
            {
                Console.WriteLine("Para sumar un alumno de colegio Publico presione 'E' y para Privado 'P'");
                colegio = Console.ReadLine();
                
                if(colegio == "E" || colegio == "e") {
                cantAlum=cantAlum+1;
                publico=publico+1;
                }
                if(colegio == "p" || colegio == "P"){
                cantAlum=cantAlum+1;
                privado=privado+1;
                }

                if(colegio == "q" || colegio == "Q"){
                    Console.WriteLine("Finalizando");
                 break;
                }
               

            }  

            Console.Clear();

            porcentajepub=(publico*100)/cantAlum;
            porcentajepriv=(privado*100)/cantAlum;

            Console.WriteLine("Resultados de los calculos: ");
            Console.WriteLine("Cantidad de alumnos: "+ "" + cantAlum);
            Console.WriteLine("Alumos públicos: " + "" + publico);
            Console.WriteLine("Alumnos Privados: " + "" + privado);
            Console.WriteLine("Porcentaje de Publicos: " + porcentajepub);
            Console.WriteLine("Porcentaje de Privados: " + privado);
            

        }
    }
}