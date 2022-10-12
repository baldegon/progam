using System;

namespace Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string divisa="";
            string fin="";               

            Console.WriteLine("Elija la moneda a convertir a continuacion ↓: ");

            while((fin != "q") && (fin != "Q")){
            Console.WriteLine("Ingrese la divisa de origen:");
            Console.WriteLine("E: EURO");
            Console.WriteLine("D: DOLAR");
            Console.WriteLine("Q: Para salir");
            fin=Console.ReadLine();
            divisa=fin;
            
            //aca va un switch para llamar las funciones en cada uno de los casos que se quieran operar
            switch(fin){
                case "E":
                convereuro();
                break;
                
                case "D":
                converdolar();
                break;
            }
            
            }
            //fin de WHILE
            Console.WriteLine("Fin de la conversion");
            Console.ReadKey();   //fin del programa si elige la OPCION "Q"      
        }
        //FUNCIONES
        static void convereuro(){
            float moneda = 0f, pesos = 0f;
            Console.WriteLine("Ingrese cantidad de Euros: ");
                moneda=Convert.ToInt32(Console.ReadLine());
                pesos=moneda * 270;
                Console.WriteLine("Ingreso: " + moneda + " Euros, son $ " + pesos );
                Console.WriteLine("Ingrese enter para hacer otra conversion");
                Console.ReadKey();
        }
        static void converdolar(){
            float moneda = 0f, pesos = 0f;
            Console.WriteLine("Ingrese cantidad de Dolar:");
            moneda=Convert.ToInt32(Console.ReadLine());
            pesos=moneda * 300;
            Console.WriteLine("Ingreso: " + moneda + " Dolares, son $ " + pesos );
            Console.WriteLine("Ingrese enter para hacer otra conversion");
            Console.ReadKey();
        }
    }   
}