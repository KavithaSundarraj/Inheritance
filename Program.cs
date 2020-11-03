using System;
/* 1.	Single Inheritance
 * Date: 03 NOV 2020
 * Create two classes named Animal and Dog.
Animal with a single public method Eat() that prints: "eating…"
Dog with a single public method Bark() that prints: "barking…"
Dog should inherit from Animal.
*/


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }

    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
}
