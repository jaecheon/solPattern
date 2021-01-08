using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/33?category=672020
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    public class Adapter : Target
    {
        Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
