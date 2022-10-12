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

            while(colegio=="e" || colegio=="E" || colegio=="p" || colegio=="P"){
                Console.WriteLine("Ingrese E para Alumnos Publicos y P para Alumnos Privados");
                colegio=Console.ReadLine();
                Console.Clear();

            if(colegio == "e" || colegio == "E")
            {
                cantAlum=cantAlum+1;
                publico=publico+1;            
            }
            if(colegio == "p" || colegio == "P")
            {
                cantAlum=cantAlum+1;
                privado=privado+1;
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
