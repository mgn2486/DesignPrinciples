using System;

namespace CommandPattern_1.Command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light has been turned ON");
        }

        public void Off()
        {
            Console.WriteLine("Light has been turned OFF");
        }
    }
}
