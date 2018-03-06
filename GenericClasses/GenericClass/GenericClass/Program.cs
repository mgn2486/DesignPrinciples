using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericClass<T>
    {
        public T mynumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var NewClass = new GenericClass<int>();
            NewClass.mynumber = 45;
            var NewClass2 = new GenericClass<bool>();
            NewClass2.mynumber = true;

            Console.WriteLine("The value of NewClass.mynumber is : " + NewClass.mynumber);
            Console.WriteLine("The value of NewClass2.mynumber is : " + NewClass2.mynumber);
            Console.ReadLine();

        }
    }
}
