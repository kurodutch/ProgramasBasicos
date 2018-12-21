using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            CrearGrid();
            Console.ReadKey();
        }

        static void CrearGrid()
        {
            int ancho = 10;
            int largo = 10;
            int numero = 0;
            int[,] cuadricula = new int[ancho, largo];
            for (int x= 0; x < ancho; x++)
            {
                for (int y=0; y< largo; y++)
                {
                    cuadricula[x, y] = numero;
                    Console.Write(cuadricula[x, y] + " " );
                    numero++;

                }
                Console.WriteLine();


            }
        }




    }
           
            
            //goto Comienzo;
            


        
    
}
