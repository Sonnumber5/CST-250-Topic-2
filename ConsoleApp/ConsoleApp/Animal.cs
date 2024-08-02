using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public virtual void Greet()
        {
            Console.WriteLine("Animal says hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal talking");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
}
