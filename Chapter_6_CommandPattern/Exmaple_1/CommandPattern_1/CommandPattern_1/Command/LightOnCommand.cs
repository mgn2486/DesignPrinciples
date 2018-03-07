using CommandPattern_1.Interface;

namespace CommandPattern_1.Command
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand( Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
