    public class TurnOffCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOff();
        }

        public void Undo()
        {
            fan.TurnOn();
        }
    }