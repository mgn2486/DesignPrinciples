using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglettonDesignPattern
{
    public class ChocolateBuilder
    {
        private Boolean empty;
        private Boolean boiled;

        private static ChocolateBuilder uniqueInstance;
        private static readonly object padlock = new object();

        public ChocolateBuilder()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBuilder getInstance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    lock (padlock)
                    {
                        if (uniqueInstance == null)
                        {
                            Console.WriteLine("NEW INSTANCE RUNNING");
                            uniqueInstance = new ChocolateBuilder();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("SORRY WE ALREADY HAVE AN INSTANCE RUNNING");
                }

                
                return uniqueInstance;
            }
            //if (uniqueInstance == null)
            //{
            //    uniqueInstance = new ChocolateBuilder();
            //}
            //return uniqueInstance;
        }

        public void fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;

                Console.WriteLine("You can refill now.......");
                
            }
            else
            {
                Console.WriteLine("Sorry The cocolate is either full or boiled.!!!!, you cannot fill");
            }
        }

        public void drain()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.WriteLine("We draining the boiled milk and chocolate");
                empty = true;
                Console.WriteLine("Now Empty.....!!!");
            }
        }

        private bool IsEmpty()
        {
            return empty;
        }

        private bool IsBoiled()
        {
            return boiled;
        }
    }

    //public sealed class Singleton
    //{
    //    private static readonly Singleton instance = new Singleton();

    //    // Explicit static constructor to tell C# compiler
    //    // not to mark type as beforefieldinit
    //    static Singleton()
    //    {
    //    }

    //    private Singleton()
    //    {
    //    }

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            return instance;
    //        }
    //    }
    //}
}
