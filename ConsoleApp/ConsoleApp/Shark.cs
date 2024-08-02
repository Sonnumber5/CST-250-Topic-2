using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Shark : Animal, ISwimmable, IPredator
    {
        public void Swim()
        {
            Console.WriteLine("Sharkey swim");
        }

        public void EatAnimal()
        {
            Console.WriteLine("MMMMM fish");
        }

        public override void Greet()
        {
            Console.WriteLine("Fish are friends, not food");
        }


    }
}
