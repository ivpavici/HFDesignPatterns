namespace CommandPattern
{
    /// <summary>
    /// 
    /// The Command Pattern encapuslates a request as an object, thereby letting you parametrize
    /// other objects wuth different requests, queue or log requests, and support undoable operations.
    /// 
    /// USES:
    /// - queuing requests
    /// - logging requests
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new SimpleRemoteControl();
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);

            remoteControl.setCommand(lightOnCommand);
            remoteControl.buttonWasPressed();
        }
    }
}
