using System;

namespace CommandDesignPattern
{
    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    // Receiver: Abstract device
    public abstract class Device
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void AdjustVolume(int level);
    }

    // Concrete Receiver: TV
    public class TV : Device
    {
        private int volume = 10;
        public override void TurnOn()
        {
            Console.WriteLine("TV is now ON.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("TV is now OFF.");
        }

        public override void AdjustVolume(int level)
        {
            volume = level;
            Console.WriteLine($"TV volume set to {volume}.");
        }
    }

    // Concrete Command: Turn On
    public class TurnOnCommand : ICommand
    {
        private Device device;

        public TurnOnCommand(Device device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.TurnOn();
        }
    }

    // Concrete Command: Turn Off
    public class TurnOffCommand : ICommand
    {
        private Device device;

        public TurnOffCommand(Device device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.TurnOff();
        }
    }

    // Concrete Command: Adjust Volume
    public class AdjustVolumeCommand : ICommand
    {
        private Device device;
        private int volume;

        public AdjustVolumeCommand(Device device, int volume)
        {
            this.device = device;
            this.volume = volume;
        }

        public void Execute()
        {
            device.AdjustVolume(volume);
        }
    }

    // Invoker: Remote Control
    public class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }

    // Client
    public class Program
    {
        public static void Main(string[] args)
        {
            Device tv = new TV();
            RemoteControl remote = new RemoteControl();

            // Turn ON TV
            remote.SetCommand(new TurnOnCommand(tv));
            remote.PressButton();

            // Adjust Volume
            remote.SetCommand(new AdjustVolumeCommand(tv, 25));
            remote.PressButton();

            // Turn OFF TV
            remote.SetCommand(new TurnOffCommand(tv));
            remote.PressButton();
        }
    }
}
