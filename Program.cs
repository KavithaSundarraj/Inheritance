using System;
/* 1.	Single Inheritance
 * Date: 03 NOV 2020
 * Create two classes named Animal and Dog.
Animal with a single public method Eat() that prints: "eating…"
Dog with a single public method Bark() that prints: "barking…"
Dog should inherit from Animal.
2.	Multiple Inheritance
Create three classes named Animal, Dog and Puppy. 
Animal with a single public method Eat() that prints: "eating…"
Dog with a single public method Bark() that prints: "barking…"
Puppy with a single public method Weep() that prints: "weeping…"
Dog should inherit from Animal. Puppy should inherit from Dog. 
3.	Hierarchical Inheritance
Create three classes named Animal, Dog and Cat. 
Animal with a single public method Eat() that prints: "eating…"
Dog with a single public method Bark() that prints: "barking…"
Cat with a single public method Meow() that prints: "meowing…"
Dog and Cat should inherit from Animal.


*/


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Single Inheritance");
            /*Console.WriteLine("Multiple Inheritance");
             Puppy puppy = new Puppy();
             puppy.Eat();
             puppy.Bark();
             puppy.Weep();*/
            Console.WriteLine("Hierarchial Inheritance");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
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
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing");
        }
    }
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping");
        }
    }
}
