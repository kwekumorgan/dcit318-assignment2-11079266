using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        public interface IMovable
        {
             void Move();
        }

        public class Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Car is Moving");
            }
        }

        public class Bicycle : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is Moving");
            }
        }
        
        static void Main(string[] args)
        {
            Car BMW = new Car();

            Bicycle BMX = new Bicycle();

            BMW.Move();

            BMX.Move();
             

        }
    }
}
