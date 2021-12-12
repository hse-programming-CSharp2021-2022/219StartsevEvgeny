using System;

namespace CW_5
{
    abstract class Animal
    {
        public string Name { get; protected set; }
        public string Age { get; protected set; }

        public void AnimalSound()
        {
            Console.WriteLine("Sound!");
        }

        public void AnimalInfo()
        {
            Console.WriteLine("Info!");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, string age, string breed, bool isTrained)
        {
            Breed = breed;
            IsTrained = isTrained;
            Name = name;
            Age = age;
        }

        public string Breed { get; private set; }
        public bool IsTrained { get; private set; }
        public new void AnimalSound()
        {
            Console.WriteLine("Bark!");
        }
        public new void AnimalInfo()
        {
            Console.WriteLine(Breed + ", " + IsTrained + ", " + Name + ", " + Age);
        }
    }

    class Cow : Animal
    {
        public Cow(string name, string age, string milkPerDay)
        {
            MilkPerDay = milkPerDay;
            Name = name;
            Age = age;
        }

        public string MilkPerDay { get; private set; }

        public new void AnimalSound()
        {
            Console.WriteLine("Mooooo!");
        }
        public new void AnimalInfo()
        {
            Console.WriteLine(MilkPerDay + ", " + Name + ", " + Age);
        }
    }

    class Program
    {

    }
}