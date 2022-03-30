using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день и месяц своего рождения");
            DateTime myBirthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;

            if(myBirthday < now)
                myBirthday = myBirthday.AddYears(1);

            TimeSpan result = myBirthday - now;

            if(myBirthday.Day == now.Day && myBirthday.Month == now.Month)
                Console.WriteLine("У вас сегодня день рождения !");
            else          
                Console.WriteLine("До вашего дня рождения остальсь {0:dd} дней  {0:hh} часов {0:mm} минут {0:ss} секунд", result);

            Console.ReadKey();

        }
    }
}
