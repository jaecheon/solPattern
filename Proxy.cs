using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/43?category=672020
    abstract class Subject
    {
        public abstract void Request() { }
    }

    class RealSubject:Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request");
        }
    }
    class Proxy: Subject
    {
        RealSubject _realSubject;
        public override void Request()
        {
            if(_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            _realSubject.Request();
        }

        public static void Run()
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
