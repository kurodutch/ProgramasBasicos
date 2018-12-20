using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    class MainClass
    {
        static void Main(string[] args)
        {

            Random NumberGenerator = new Random();
            int diferencia;
            int num01 = NumberGenerator.Next(1, 11);
            int num02 = NumberGenerator.Next(1, 11); //Next devuelve un valor entero no negativo.
            int respuesta;
            int RespuestaCorrecta;
            Console.Write("Cuanto es " + num01 + " multiplicado por " + num02 + " ? ");
            respuesta = Convert.ToInt32(Console.ReadLine());
            RespuestaCorrecta = num01 * num02;
            if (respuesta == num01 * num02)
            {
                int IndiceRespuesta1 = NumberGenerator.Next(1, 4);
                switch (IndiceRespuesta1)
                {
                    case 1:
                        Console.WriteLine("Wena, loco weno");
                        break;
                    case 2:
                        Console.WriteLine("Loco Maquinola");
                        break;
                    default:
                        Console.WriteLine("Estoy orgulloso de ti");
                        break;
                }
                
            } else{
                int IndiceRespuesta2 = NumberGenerator.Next(1, 4);
                switch (IndiceRespuesta2)
                {
                    case 1:
                        Console.WriteLine("wn penca");
                        break;
                    case 2:
                        Console.WriteLine("wn mula");
                        break;
                    default:
                        Console.WriteLine("wn basura");
                        break;
                }

                
            }
            diferencia = Math.Abs(respuesta - RespuestaCorrecta);
            if (diferencia <= 10 & diferencia!= 0)
            {
                Console.WriteLine("Te equivocaste por poco");
            }
            else if (diferencia > 10 & diferencia <= 30){
                Console.WriteLine("Te equivocaste por bastante");
            }
            else
            {
                Console.WriteLine("Te equivocaste mas que la cresta, wn penca");
            }
            Console.ReadKey();

           
        }
    }
}
