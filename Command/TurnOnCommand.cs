public class TurnOnCommand : ICommand
{
    private readonly Fan fan;

    public TurnOnCommand(Fan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        fan.TurnOn();
    }

    public void Undo()
    {
        fan.TurnOff();
    }
}