using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Animal beast = new Animal();

            beast.Talk();
            beast.Greet();
            beast.Sing();
           

            Dog obiWan = new Dog();


            obiWan.Talk();
            obiWan.Greet();
            obiWan.Sing();
            obiWan.Fetch("Stick");
            obiWan.FeedMe();
            obiWan.TouchMe();

            Robin red = new Robin();

            red.Talk();
            red.Greet();
            red.Sing();
           */

            Snake samuelTheSnake = new Snake();

            samuelTheSnake.Swim();
            samuelTheSnake.Sing();
            samuelTheSnake.Slithering();

            Console.WriteLine();

            Penguin peterPenguin = new Penguin();

            peterPenguin.Swim();
            peterPenguin.Greet();

            Console.WriteLine();

            Shark shawnShark = new Shark();

            shawnShark.Swim();
            shawnShark.EatAnimal();
            shawnShark.Greet();
            shawnShark.Sing();



            Console.ReadLine();
        }
    }
}