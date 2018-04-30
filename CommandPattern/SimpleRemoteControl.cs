namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;

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
