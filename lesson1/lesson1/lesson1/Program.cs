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
            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            var family = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            var age = Console.ReadLine();
            Console.WriteLine("Введите рост:");
            var height = Console.ReadLine();
            Console.WriteLine("Введите вес:");
            var weight = Console.ReadLine();

            // используя  склеивание: //Console.WriteLine("«Анкета» \nИмя: " + name+"\n"+"Фамилия: "+family+"\n"+"Возраст: "+age+"\n"+"Рост: "+height+"\n"+"Вес: "+weight);
            // используя форматированный вывод: //Console.WriteLine("«Анкета» \nИмя: {0}\nФамилия: {1}\nВозраст: {2}\nРост: {3}\nВес: {4}",name,family,age,height,weight);
            // используя вывод со знаком $:
            Console.WriteLine($"«Анкета» \nИмя: {name}\nФамилия: {family}\nВозраст: {age}\nРост: {height}\nВес: {weight}");
        }
    }
}
