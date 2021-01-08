using System;
using System.Collections.Generic;
using System.Text;

namespace solPattern
{
    public abstract class Prototype
    {
        string _id;

        public Prototype(string id)
        {
            this._id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    public class Concrete1Prototype : Prototype
    {
        public Concrete1Prototype(string id) : base(id)
        { }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
    public class Concrete2Prototype : Prototype
    {
        public Concrete2Prototype(string id) : base(id)
        { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
