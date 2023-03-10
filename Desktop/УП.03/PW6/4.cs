using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW6_4
{
    class Animal
    {
        private string Name
        {
            get;
            set;
        }
        private int Age
        {
            get;
            set;
        }
        private int Legs
        {
            get;
            set;
        }
        private string Species
        {
            get;
            set;
        }
        private string Status
        {
            get;
            set;
        }
        public void Introduce()
        {
            Console.WriteLine($"Привет, мое имя {Name} и мне {Age} лет.");
        }
        public Animal (string name, int age, int legs, string species, string status)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Species = species;
            Status = status;
        }
    }
    class Shark : Animal
    {
        public Shark (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 0;
            species = "акулы";
        }
    }
    class Cat : Animal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу мяу!");
        }
        public Cat (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "кошки";
        }
    }
    class Dog: Animal
    {
        private string Master;
        public void GreetMaster()
        {
            Console.WriteLine($"Привет, {Master}!");
        }
        public Dog (string name, int age, int legs, string species, string status, string master) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "собаки";
            Master = master;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание. Создать класс Животное со свойствами Имя, Возраст, Количество ног, Вид, Статус. Создать 3 наследника класса Животное: Акула, Кошка и Собака. Для двух наследников добавить новые методы.");
            Animal Anaconda = new Animal("Анаконда", 20, 0, "удавы", "спит");
            Anaconda.Introduce();
            Shark GreatShark = new Shark("Белая акула", 2, 0, "", "охотится");
            Cat Murka = new Cat("Мурка", 7, 4, "", "свободна");
            Murka.Introduce();
            Murka.Voice();
            Dog Bim = new Dog("Бим", 12, 4, "", "ест", "Анастасия");
            Bim.GreetMaster();
            Console.ReadKey(true);
        }
    }
}