using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            int x1, y1, x2, y2;
            Console.WriteLine("Введите координату X1:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y1:");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату X2:");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y1:");
            y2 = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:F2}", result);

        }
    }
}
