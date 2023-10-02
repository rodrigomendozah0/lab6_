using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max_per;
            Console.Write("Ingrese el número maximo de personas: ");
            max_per = int.Parse(Console.ReadLine());

            Console.Clear();

            int asistentes_act = 0;
            int per_ingresaron = 0; 
            int per_salieron = 0;
            int veceslleno = 0;
            int vecesvacio = 0;

            while (true)
            {
                float aforo = (float)asistentes_act / max_per * 100;

                Console.WriteLine("************************");
                Console.WriteLine("|Asistentes actuales|" + asistentes_act);
                Console.WriteLine("|Aforo|" + aforo.ToString("0.00") + "%");
                Console.WriteLine("|Maximo|" + max_per + " personas");
                Console.WriteLine("************************");

                Console.WriteLine("Presione");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");

                char opcion = Console.ReadKey().KeyChar;

                Console.Clear();

                switch (opcion)
                {
                    case 'i':
                        if (asistentes_act < max_per)
                        {
                            asistentes_act++;
                            per_ingresaron++;
                        }
                        else
                        {
                            Console.WriteLine("El local está lleno");
                            veceslleno++;
                        }
                        break;
                    case 's':
                        if (asistentes_act > 0)
                        {
                            asistentes_act--;
                            per_salieron++;
                        }
                        else
                        {
                            Console.WriteLine("El local está vacio");
                            vecesvacio++;
                        }
                        break;
                    case 'x':
                        Console.WriteLine("************************");
                        Console.WriteLine("El programa ha terminado");
                        Console.WriteLine("************************");

                        Console.WriteLine("Estadísticas");
                        Console.WriteLine("************************");
                        Console.WriteLine(per_ingresaron + " personas ingresaron");
                        Console.WriteLine(per_salieron + " personas salieron");
                        Console.WriteLine(veceslleno + " veces se llenó el local");
                        Console.WriteLine("Estuvo vació " + vecesvacio + " veces");
                        break;
                }
            }
        }
    }
}
