using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backrooms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, это эксперементальный проект в C# по ислледованию реального мира!");
            Console.Write("Куда хотите пойти: прямо / направо / налево ?: ");
            string direct = Console.ReadLine();
            Console.Write("Ой, вы провалились сквозь пол ");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(". ");
            }
            Thread.Sleep(1000);
            Console.WriteLine("\nВы оказались в Закулисье.");
            Console.WriteLine("Вы попали на Уровень 0.");






            Console.ReadKey();
        }
    }
}
