using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgram
{
    class MainClass
    {

        enum Raza {Akita, Boxer, Chihuahua, Cocker, Labrador, Pug};
        //Clase Base
        class Animal
        {
            public string nombre;
            public byte edad;
            public float felicidad;
        }

        //Clase Derivada
        class Perro : Animal
        {
            public Raza raza;
            public Perro(string _nombre, byte _edad, float _felicidad, Raza _raza)
            {
                nombre = _nombre;
                edad = _edad;
                felicidad = _felicidad;

                raza = _raza;

            }
            public void Print() //imprime info de nuestro perro en la pantalla.
            {
                Console.WriteLine("nombre: " + nombre);
                Console.WriteLine("edad: " + edad);
                Console.WriteLine("felicidad: " + felicidad);
                Console.WriteLine("Raza: " + raza);
            }

            



        }

        public static void Main( string[] args)
        {
            Perro Ronaldo = new Perro("Ronaldo", 14, 0.8f, Raza.Cocker);
            Ronaldo.Print();
            Perro Peggy = new Perro("Peggy", 2, 0.9f, Raza.Pug);
            Peggy.Print();
            Console.ReadKey();









        }

    }

}
