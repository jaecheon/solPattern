using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/37?category=672020
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    class Composite : Component
    {
        List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component c)
        {
            _children.Add(c);
        }
        public override void Remove(Component c)
        {
            _children.Remove(c);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach(Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }

    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
