using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Method_Overriding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal generic = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            generic.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
