using System;

namespace Capitulo4
{
    class Program
    {
        //Ejercicio 1
        public static void Multiplicar()
        {
            int n;
            string linea;
            Console.Write("Ingrese el numero que desee multiplicar: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(n + " x " + i + " = " + i * n + "\n");
            }
        }
        // Ejercicio 2
        public static void Potencia()
        {
            int numeno = 0;
            Console.WriteLine("Digite el numero que desee elevar: ");
            numeno = Convert.ToInt32(Console.ReadLine());

            int potencia = 0;
            Console.WriteLine("Digite la potencia a la cual sera elevada el numero: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            double resultado = Math.Pow(numeno,potencia);
            Console.WriteLine($"El resultado es: {resultado}");
        }
        // Ejercicio 5
        public static void Promedio()
        {
            int Personas = 0;
            Console.WriteLine("Ingrese la cantidad de personas que se encuentran en el grupo: ");
            Personas = Convert.ToInt32(Console.ReadLine());
            double resultado = 0;
            int Acumulado = 0;
            for (int i = 0; i < Personas; i++)
            {
                int edad = 0;
                
                Console.WriteLine("Ingrese la edad de la persona: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Acumulado += edad;
            }
            resultado = Acumulado / Personas;
            Console.WriteLine($"EL Promedio de la edades es: {resultado}");
        }
        static void Main(string[] args)
        {
            int num = 0;
            int opcion = 0;
            Console.WriteLine("1- Tabla de multiplicar \n2- Potencia \n3- Promedio");
            Console.WriteLine("Elija una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                default:
                    Console.WriteLine("Opcion no valida, vuelva a intentar...");
                    break;
                case 1:
                    Multiplicar();
                    break;
                case 2:
                    Potencia();
                    break;
                case 3:
                    Promedio();
                    break;
            }
        }
    }
}

  
