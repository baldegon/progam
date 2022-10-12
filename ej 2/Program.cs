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

/*using System;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           int publico=0, privado=0, cantidadAlumnos=0;
            string institución="e";
            float porcentajePublico=0f;
            float porcentajePrivado=0f;


            Console.WriteLine("Sistema de alumnos públicos / privados");

            while (institución=="e"|| institución=="E"|| institución=="p" || institución=="P"){
                Console.WriteLine("Ingrese E para alumno publico; ingrese P para privado, x salir");
                institución=Console.ReadLine();
                Console.Clear();

                if(institución =="e" || institución=="E"){
                        cantidadAlumnos= cantidadAlumnos+1;
                        publico= publico+1;
                }
                if(institución== "p" || institución=="P"){

                    cantidadAlumnos= cantidadAlumnos+1;
                    privado= privado+1;

                }
                if(institución=="X" || institución=="x"){
                    Console.WriteLine("Saliendo del sistema ....");
                    Console.ReadKey();
                    institución="salir";
                } 
                


            }
            Console.Clear();

            porcentajePrivado=(privado*100)/cantidadAlumnos;
            porcentajePublico=(publico*100)/cantidadAlumnos;

            Console.WriteLine("Sistema de alumnos en colegios públicos o colegios privados");
            Console.WriteLine("Cantidad de Alumnos: " + cantidadAlumnos);
            Console.WriteLine("Cantidad de Privados: " + privado);
            Console.WriteLine("Cantidad de Publicos: " + publico);
            Console.WriteLine("Porcentaje de Publicos: " + porcentajePublico + " %");
            Console.WriteLine("Porcentaje de Privados: " + porcentajePrivado + " %");


        }
    }
}*/