using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Penguin : Animal, ISwimmable
    {
        public Penguin()
        {
            Console.WriteLine("Penguin Constructor");
        }

        public void Swim()
        {
            Console.WriteLine("Penguiney swim");
        }

        public override void Greet()
        {
            Console.WriteLine("\"Hello\" *in penguine language*");
        }
    }
}
