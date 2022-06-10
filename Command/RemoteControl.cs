    public class Remote
    {
        private readonly ICommand turnOnCommand;
        private readonly ICommand turnOffCommand;

        public Remote(ICommand turnOnCommand, ICommand turnOffCommand)
        {
            this.turnOnCommand = turnOnCommand;
            this.turnOffCommand = turnOffCommand;
        }

        public void TurnOnButtonClick()
        {
            turnOnCommand.Execute();
        }

        public void TurnOffButtonClick()
        {
            turnOffCommand.Execute();
        }
    }  
