using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie14
{
    abstract class Animal
    {
        // абстрактное свойство без реализации
        public abstract string Name { get; set; } 
        // конструктор который установит значение по умолчанию для названия
        public Animal(string name) 
        {
            Name = name;
        }
        // абстрактный метод - вывод звука животного
        public abstract void Say(); 
        // метод вывода названия и звука животного
        public void ShowInfo() 
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    // дочерний класс Кошки
    class Cat : Animal
    {
        string breed; 
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string breed, string say)
            : base(name)
        {
            this.breed = breed;
        }
        public override void Say()
        {
            Console.WriteLine(breed);
            Console.WriteLine("Мяу");
            Console.WriteLine();
        }
    }
    // дочерний класс - Собаки
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}

