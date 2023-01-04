using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonizationHeroes3
{
    class Program
    {
        static int temp ()
        {
            int temp = 0;
            bool trial = true;

            while (true)
            {
                try
                {
                    temp = Int32.Parse(Console.ReadLine());
                    if (temp >= 1)
                    {
                        trial = false;
                        return temp;
                    }
                }
                catch (Exception)
                {
                    //throw new ArgumentOutOfRangeException("the input value must not be less than one");
                    Console.WriteLine("Попробуй снова");
                }
            }
        }

        static void Main(string[] args)
        {
            int PitLords;
            int UnitHP;

            while (true)
            {
                Console.WriteLine("Введите количество питлордов -");
                PitLords = temp();
                Console.Clear();
                Console.WriteLine($"Введите количество питлордов - {PitLords}");
                Console.WriteLine("Введите количество HP жертвы -");
                UnitHP = temp();
                Console.Clear();
                Console.WriteLine($"Количество питлордов - {PitLords}");
                Console.WriteLine($"Количество HP жертвы - {UnitHP}");
                DemonizationHeroes Сalculation = DemonizationHeroes.Create((int)PitLords, (int)UnitHP);
                Console.WriteLine();
                Console.WriteLine($"Необходимое количество существ - {Сalculation._necessaryCreatures}");
                Console.WriteLine($"Получаемое количество демонов - {Сalculation._creaturesSummoned}");
                Console.WriteLine();
                Console.WriteLine(Сalculation.message);


                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
