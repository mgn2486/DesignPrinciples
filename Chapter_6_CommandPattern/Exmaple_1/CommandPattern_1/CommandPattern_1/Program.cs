using System;
using CommandPattern_1.Command;
using CommandPattern_1.ConcreteClasses;

namespace CommandPattern_1
{

    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();

            LightOnCommand lightOn = new LightOnCommand(light);

            remote.setCommand(lightOn);
            remote.buttonWasPressed();

            Console.ReadLine();
        }
    }


}
