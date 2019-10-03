//!готово!-основні операції над статичною/динамічною чергою;
//-змінити місцями перший та останній елемент черги;
//-розвернути чергу;
//-!готово!видалити всі елементи черги;
//-!готово!операція «чи належить заданий елемент» статичній/динамічній черзі.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            foreach (string item in queue)
                Console.WriteLine(item);
            Console.WriteLine();
            queue.Reverse();
            foreach (string item in queue)
                Console.WriteLine(item);
            //Console.WriteLine();
            //string firstItem = queue.Dequeue();
            //Console.WriteLine($"Извлеченный элемент: {firstItem}");
            //Console.WriteLine();

            //foreach (string item in queue)
            //    Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
