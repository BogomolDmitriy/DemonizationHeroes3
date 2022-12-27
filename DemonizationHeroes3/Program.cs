using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonizationHeroes3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите количество питлордов -");
            double PitLords = Double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Введите количество питлордов - {PitLords}");
            Console.WriteLine("Введите количество HP жертвы -");
            double UnitHP = Double.Parse(Console.ReadLine());
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
        }

    }
}
