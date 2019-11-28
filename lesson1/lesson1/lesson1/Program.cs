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
            
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Введите вес(кг):");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост(см):");
            double h = double.Parse(Console.ReadLine());

            double height = h / 100;

            int IMT = Convert.ToInt32(weight / (height * height));

            Console.WriteLine($"Ваш индекс массы тела: {IMT}");

        }
    }
}
