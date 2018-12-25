using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgram
{
    class Animal
    {

        public string nombre;
        public byte edad;
        public float felicidad;

        public void PrintBase()
        {
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("edad: " + edad);
            Console.WriteLine("felicidad: " + felicidad);

        }

    }

    class Perro: Animal
    {
        public int NumManchas;
        public void ladrido()
        {
            Console.WriteLine("GUAF!");
            base.felicidad +=0.1f;
        }
        

    }

   



    class Gato : Animal
    {
        public float lindura;
        public void maullido()
        {
            Console.WriteLine("MIAU!");

        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            Perro Ronaldo = new Perro();
            Ronaldo.nombre = "Ronaldo";
            Ronaldo.edad = 14;
            Ronaldo.felicidad = 0.8f;
            Ronaldo.NumManchas = 19;
            Ronaldo.PrintBase();    
            Ronaldo.ladrido();
            Console.WriteLine("nueva felicidad: " + Ronaldo.felicidad);

            Console.WriteLine();

            Gato cachulo = new Gato();
            cachulo.nombre = "Cachulo";
            cachulo.edad = 14;
            cachulo.felicidad = 0.3f;
            cachulo.PrintBase();
            cachulo.maullido();
            Console.ReadKey();
            



        }
    }
}
