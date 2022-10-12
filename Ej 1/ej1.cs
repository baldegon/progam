using System;

namespace alumnos
{
    class Program
    {   
        
        static void Main(string[] args)
        {  
            string Cursononombre, turno;
            int alumnos;
            int calificaciones;
            float resultadocalificaciones = 0f;
            float promedio=0f;

            Console.WriteLine("Bienvenido al sistema de calculo de Calificaiones");
            Console.WriteLine("Porfavor aprete una tecla para continuar: ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Porfavor primero ingrese el nombre del Curso:  ");
            Cursononombre=Console.ReadLine();
            
            Console.WriteLine("Ingrese El turno: ");
            turno=Console.ReadLine();
            
            Console.WriteLine("Ingrese La cantidad de Alumnos: ");
            alumnos = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < alumnos; i++){
                Console.WriteLine("Ingrese nota: ");
                calificaciones=Convert.ToInt32(Console.ReadLine());
                resultadocalificaciones=resultadocalificaciones+calificaciones;               
            }

            promedio = (resultadocalificaciones/alumnos);
            Console.WriteLine("Nombre del curso: " + Cursononombre);
            Console.WriteLine("Turno: " + turno);
            Console.WriteLine("Promedio: " + promedio);

            


            
        }
    }
}