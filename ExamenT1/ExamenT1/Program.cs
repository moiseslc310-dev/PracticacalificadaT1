using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntregadeCarnets();
            Console.ReadKey();

        }

        //Creando un metodo
        static void EntregadeCarnets()
        {
            Console.Write("Ingrese la cantidad de estudiantes a evaluar: ");
            int cantEstudiante=int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            int nronuevos = 0;
            int nroRenovacion = 0;
            int nroVencidos = 0;

            //Estructura repetitiva
            for (int i = 1;i<=cantEstudiante;i++)
            {
                Console.WriteLine();
                Console.Write($"Ingrese el año de ingreso del estudiante {i}: ");
                int año=int.Parse(Console.ReadLine());
                //Estructura condicional
                if (año == 2025)
                {
                    Console.WriteLine("Resultado: Carnet nuevo");
                    nronuevos=nronuevos+1;
                }
                else if (año>=2023 && año<=2024)
                {
                    Console.WriteLine("Resultado: Carnet en renovación");
                    nroRenovacion=nroRenovacion+1;
                }
                else if(año<2023)
                {
                    Console.WriteLine("Resultado: Carnet venido, requiere tramite epecial");
                    nroVencidos=nroVencidos+1;
                }
                else
                {
                    Console.WriteLine("El año ingresado no cumple requisito, es superior al 2025");
                }

            }

            //Mostrar Resultados
            Console.WriteLine();
            Console.WriteLine("_________ RESUMEN ESTADISTICO------------- ");
            Console.WriteLine($"Numero de Carnets nuevos: {nronuevos}");
            Console.WriteLine($"Numero de Carnets en renovación: {nroRenovacion}");
            Console.WriteLine($"Numero de Carnets vencidos: {nroVencidos}");


        }

    }
}
