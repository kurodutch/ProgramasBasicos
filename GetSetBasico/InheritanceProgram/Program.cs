using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgram
{
    class MainClass
    {
        class Player
        {
            private int _salud = 100;
            //public int salud = 100;
            public int dañotomado;
            public string nombre;
            public int salud
            {
                get
                {
                    return _salud;
                }
                set
                {
                    if (value <= 0)
                    {
                        _salud = 0;
                    } else if (value >= 100)
                    {
                        _salud = 100;
                    }
                    else
                    {
                        _salud = value;
                    }



                }

            }
            public Player()
            {

            }

            public Player (int _salud, string _nombre){
                salud = _salud;
                nombre = _nombre;

            }

            public void Daño(int _daño)
            {
                _salud -=_daño;
                dañotomado = _daño;
            }   
        }
        public static void Main( string[] args)
        {
            Player Juan = new Player(100, "Juan");
            Console.WriteLine("Nombre: " + Juan.nombre + " Salud: " + Juan.salud);
            Player Tom = new Player();
            Tom.Daño(47);
            Console.WriteLine(Tom.salud);
            Tom.salud -= 200;
            Console.WriteLine(Tom.salud);
            Tom.salud += 400;
            Console.WriteLine(Tom.salud);
            Console.WriteLine("El jugador tomó " + Tom.dañotomado+ " de daño, su salud actual es " + Tom.salud);
            Console.ReadKey();





        }

    }

}
