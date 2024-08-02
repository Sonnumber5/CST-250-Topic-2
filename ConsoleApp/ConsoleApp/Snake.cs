using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Snake : Animal, ISlither, ISwimmable
    {
        public Snake()
        {
            Console.WriteLine("Snake Constructor");
        }

        public void Slithering()
        {
            Console.WriteLine("Ssssssssslither");
        }

        public override void Sing()
        {
            Console.WriteLine("Here comes the Sssssssssun");
        }

        public void Swim()
        {
            Console.WriteLine("Snakey swim");
        }
    }
}
