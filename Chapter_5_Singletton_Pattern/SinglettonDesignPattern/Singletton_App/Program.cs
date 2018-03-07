using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglettonDesignPattern;

namespace Singletton_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var chocolateObject = ChocolateBuilder.getInstance();

            var chocolateObject = ChocolateBuilder.getInstance;
            chocolateObject.fill();
           
            chocolateObject.drain();
            chocolateObject.fill();
            chocolateObject.fill();
            var chocolateObject2 = ChocolateBuilder.getInstance;

            Console.ReadLine();

        }

    }

}
