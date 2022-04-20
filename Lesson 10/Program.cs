using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Введите имя");
            p1.name =Console.ReadLine();
            Console.WriteLine("введите возраст");
            p1.age = int.Parse(Console.ReadLine());

            int dBith = Person.year - p1.age;
            Console.WriteLine("Имя {0}, возраст {1}, год рождения {2}", p1.name, p1.age, dBith);

            Console.ReadKey();
            
        }
    }
}


class Person
{
    public static int year = 2022;
    public int age;
    public string name;
}