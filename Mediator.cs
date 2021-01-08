using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/46?category=672020
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    class ConcreteMediator:Mediator
    {
        ConcreteColleague1 _colleague1;
        ConcreteColleague2 _colleague2;

        public ConcreteColleague1 Colleague1
        {
            set { _colleague1 = value; }
        }
        public ConcreteColleague2 Colleague2
        {
            set { _colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if(colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }

    abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator):base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message : " + message);
        }
    }

    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message : " + message);
        }
    }

    class MediatorInvoker
    {
        public static void Run()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.
        }
    }
}
