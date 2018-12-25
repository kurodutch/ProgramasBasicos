using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPrueba
{

    class Animal
    {
        public static int count = 0;

        public string nombre;
        public  byte edad;
        public  float felicidad;

        public Animal()
        {
            nombre = "pepito";
            edad = 6;
            felicidad = 0.5f;

            count++;
        }

        public Animal(string _nombre, byte _edad, float _felicidad)
        {
            nombre = _nombre;
            edad = _edad;
            felicidad = _felicidad;

        }


        public void Print()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Felicidad: " + felicidad);

        }


    }




    class Program
    {
        static void Main(string[] args)
        {

            Animal Perro = new Animal();

            Perro.Print();
            Console.WriteLine();

            Animal gato = new Animal("pepita", 18, 0.8f);
            gato.Print();

            Console.ReadKey();

         }


        //goto Comienzo;


    }


}
