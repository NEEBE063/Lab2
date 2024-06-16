using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Bicycle[] arrBicycles;
            Console.Write("Введіть кількість велосипедів: ");
            int ByciclesCount = Convert.ToInt32(Console.ReadLine());
            arrBicycles = new Bicycle[ByciclesCount];
            for (int i = 0; i < ByciclesCount; i++)
            {
                Console.WriteLine("Введіть модель");
                string sModel = Console.ReadLine();
                Console.WriteLine("Введіть раму");
                string sFrame = Console.ReadLine();
                Console.WriteLine("Введіть передачі");
                int sBroadcast = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть вилку");
                string sFork = Console.ReadLine();
                Console.WriteLine("Введіть сидіння");
                string sHeadset = Console.ReadLine();
                Console.WriteLine("Введіть руль");
                string sHandlebars = Console.ReadLine();
                Console.WriteLine("Чи є дзвінок(y - yes, or n - no)");
                ConsoleKeyInfo keyHasRing = Console.ReadKey();
                Bicycle bc = new Bicycle
                {
                    Model = sModel,
                    Frame = sFrame,
                    Broadcast = sBroadcast,
                    Headset = sHeadset,
                    Handlebars = sHandlebars,
                    Fork = sFork,
                    Ring = keyHasRing.Key == ConsoleKey.Y ? true : false
                };
                arrBicycles[i] = bc;
            }
            int counter = 1;
            foreach (Bicycle bc in arrBicycles)
            {
                Console.WriteLine($"Велосипед[{counter++}] Деталі:");
                Console.WriteLine("-------------");
                Console.WriteLine($"Модель: {bc.Model}");
                Console.WriteLine($"Рама: {bc.Frame}");
                Console.WriteLine($"Передачі: {bc.Broadcast}");
                Console.WriteLine($"Рульова колонка: {bc.Headset}");
                Console.WriteLine($"Руль {bc.Handlebars}");
                Console.WriteLine($"Вилка: {bc.Fork}");
                Console.WriteLine($"Дзвінок: {(bc.Ring ? "Є дзвінок" : "Немає дзвінка")}");
                Console.WriteLine($"4k = {bc.Cost()}");
            }
            Console.WriteLine("Нажміть кнопку щоб вийти");
            Console.ReadKey();

        }
    }
}
