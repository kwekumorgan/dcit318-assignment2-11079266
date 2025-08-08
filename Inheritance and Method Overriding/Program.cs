using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Method_Overriding
{
    internal class Program
    {
        // base class
        public class Animal
        {
            // method to allow overriding
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }


        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }


        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();

            Dog germanSheperd = new Dog();

            Cat persian = new Cat();


            myAnimal.MakeSound();
            germanSheperd.MakeSound();
            persian.MakeSound();


        }
    }
}
