using System;
using System.CodeDom;
using CommandPattern_1.Interface;

namespace CommandPattern_1.ConcreteClasses
{
    public class SimpleRemoteControl
    {
        private ICommand slot;

        public SimpleRemoteControl()
        {
        }

        public void setCommand(ICommand command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.Execute();
        }

    }

}
