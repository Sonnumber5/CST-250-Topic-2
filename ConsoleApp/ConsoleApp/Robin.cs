using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Robin : Animal
    {
        public virtual void Sing()
        {
            Console.WriteLine("Chirp chirp");
        }
    }
}
