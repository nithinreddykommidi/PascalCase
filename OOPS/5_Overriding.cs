using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    internal class _5_Overriding
    {
        // To override inherited method must be abstracti,virtual, or already overriden used with ToString(), polymorphism 
        public static void Main()
        {
            Animal animal= new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();

            animal.Bark();
            cat.Bark();
            cat.Bark();
        }

    }

    class Animal
    {
        public  virtual void Bark() 
        {
            Console.WriteLine("The animal says * brrr *");
        }
    }

    class Dog : Animal 
    {// To override a method we should use override 
        public override void Bark()
        {
            Console.WriteLine("The Dog says * whoff *");
        }
    }

    class Cat : Animal 
    {
        public override void Bark()
        {
            Console.WriteLine("The cat says * meow *");
        }

    }
}   

