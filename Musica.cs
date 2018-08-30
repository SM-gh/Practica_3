using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            char eleccion, accion;

            Piano piano = new Piano();
            piano.Tocar(piano.sonido);
            piano.Afinar(piano.afinado);
            piano.Tipo(piano.tipo);
            Violin violin = new Violin();
            violin.Tocar(violin.sonido);
            violin.Afinar(violin.afinado);
            violin.Tipo(violin.tipo);
            Marimba marimba = new Marimba();
            marimba.Tocar(marimba.sonido);
            marimba.Afinar(marimba.afinado);
            marimba.Tipo(marimba.tipo);
            Arpa arpa = new Arpa();
            arpa.Tocar(arpa.sonido);
            arpa.Afinar(arpa.afinado);
            arpa.Tipo(arpa.tipo);
            Fagot fagot = new Fagot();
            fagot.Tocar(fagot.sonido);
            fagot.Afinar(fagot.afinado);
            fagot.Tipo(fagot.tipo);


            Eleccion();
            void Eleccion()
            {
                Console.Clear();
                Console.WriteLine("Escoge el instrumento musical:\n a)Piano\n b)Violin\n c)Arpa\n d)Marimba\n e)Fagot");
                eleccion = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (eleccion)
                {
                    case 'a':
                        Accion();
                        if (accion == '1')
                        {
                            Console.WriteLine(piano.sonido);
                        }
                        else if (accion == '2')
                        {
                            Console.WriteLine(piano.afinado);
                        }
                        else if (accion == '3')
                        {
                            Console.WriteLine(piano.tipo);
                        }
                        else
                        {
                            Eleccion();
                        }
                        break;
                    case 'b':
                        Accion();
                        if (accion == '1')
                        {
                            Console.WriteLine(violin.sonido);
                        }
                        else if (accion == '2')
                        {
                            Console.WriteLine(violin.afinado);
                        }
                        else if (accion == '3')
                        {
                            Console.WriteLine(violin.tipo);
                        }
                        else
                        {
                            Eleccion();
                        }
                        break;
                    case 'c':
                        Accion();
                        if (accion == '1')
                        {
                            Console.WriteLine(arpa.sonido);
                        }
                        else if (accion == '2')

                        {
                            Console.WriteLine(arpa.afinado);
                        }
                        else if (accion == '3')
                        {
                            Console.WriteLine(arpa.tipo);
                        }
                        else
                        {
                            Eleccion();
                        }
                        break;
                    case 'd':
                        Accion();
                        if (accion == '1')
                        {
                            Console.WriteLine(marimba.sonido);
                        }
                        else if (accion == '2')
                        {
                            Console.WriteLine(marimba.afinado);
                        }
                        else if (accion == '3')
                        {
                            Console.WriteLine(marimba.tipo);
                        }
                        else
                        {
                            Eleccion();
                        }
                        break;
                    case 'e':
                        Accion();
                        if (accion == '1')
                        {
                            Console.WriteLine(fagot.sonido);
                        }
                        else if (accion == '2')
                        {
                            Console.WriteLine(fagot.afinado);
                        }
                        else if (accion == '3')
                        {
                            Console.WriteLine(fagot.tipo);
                        }
                        else
                        {
                            Eleccion();
                        }
                        break;
                    default:
                        Eleccion();
                        break;
                }
            }

            void Accion()
            {
                Console.WriteLine("¿Que quieres hacer?\n 1)Tocarlo\n 2)Afinarlo\n 3)Tipo");
                accion = Console.ReadKey().KeyChar;
                Console.Clear();
            }
            Console.ReadLine();
            Eleccion();
        }
    }
}
