using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2.Practicas_Evaluativas_Unidad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " \"PE-2. Practicas Evaluativas Unidad 2\"";
            Metodos Sucesion;
            bool Condicion = true;
            string Opcion;
            int sucesion, tamaño;
            ConsoleKey key;
            do
            {
                try
                {
                    Console.Write(" De cuantos elementos es la sucesion?: ");
                    tamaño = int.Parse(Console.ReadLine());
                    Console.Write(" Introduce la sucesion: ");
                    sucesion = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Que deseas hacer con la sucesion? \n 1) Obtener el valor maximo de la sucesion.  2) Obtener el valor minimo de la sucesion.  3) Invertir la sucesion. ");
                    key = Console.ReadKey().Key;
                    switch(key)
                    {
                        case ConsoleKey.D1:
                            if (tamaño < 0)
                            {
                                Condicion = true;
                                Console.WriteLine(" Error de tamaño de la sucesion, precione cualquier tecla para reiniciar el programa... ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Sucesion = new Metodos(tamaño,sucesion);
                                Console.WriteLine(" El numero mayor de la sucesion es: {0}", Sucesion.MaximoValor(tamaño));
                            }
                            break;
                        case ConsoleKey.D2:
                            if (tamaño < 0)
                            {
                                Condicion = true;
                                Console.WriteLine(" Error de tamaño de la sucesion, precione cualquier tecla para reiniciar el programa... ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Sucesion = new Metodos(tamaño,sucesion);
                                Console.WriteLine("\n El numero menor de la sucesion es: {0}", Sucesion.MinimoValor(tamaño));
                            }
                            break;
                        case ConsoleKey.D3:
                            Sucesion = new Metodos(tamaño,sucesion);
                            Sucesion.SucesionInversa(sucesion);
                            break;
                        default:

                            break;
                    }
                    Console.Write(" Desea reiniciar el programa? (Si/No): ");
                    Opcion = Console.ReadLine();
                    switch(Opcion.ToUpper())
                    {
                        case "SI":
                            Condicion = true;
                            Console.WriteLine(" Presione cualquier recla para reiniciar... ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "NO":
                            Condicion = false;
                            Console.WriteLine(" Cerrando programa... ");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine(" Opcion incorrecta!, se reiniciara el programa... ");
                            Console.ReadKey();
                            break;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (Condicion == true);
        }
    }
}
