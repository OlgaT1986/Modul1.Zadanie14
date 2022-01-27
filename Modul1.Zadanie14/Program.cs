using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Манчкин", "Британец", "");
            cat.ShowInfo();
            Dog dog = new Dog("Чау-чау", "");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}

