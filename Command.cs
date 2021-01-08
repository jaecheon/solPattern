using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/44?category=672020
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    class ConcreteCommand: Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) { }
        public override void Execute()
        {
            receiver.Action();
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }

    class Invoker
    {
        Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

        public static void Run()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);

            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
