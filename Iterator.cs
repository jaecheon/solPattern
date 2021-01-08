﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    //https://codepump.tistory.com/45?category=672020
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    class ConcreteAggregate : Aggregate
    {
        ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    class ConcreteIterator : Iterator
    {
        ConcreteAggregate _aggregate;
        int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggreate)
        {
            this._aggregate = aggreate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if(_current < _aggregate.Count -1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public static void Run()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            ConcreteIterator i = new ConcreteIterator(a);

            Console.WriteLine("Iterating over collection: ");

            object item = i.First();
            while(item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
