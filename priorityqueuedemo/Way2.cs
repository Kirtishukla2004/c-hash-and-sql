using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace priorityqueuedemo
{
    interface Iitems
    {
        int itempriority { get; }
    }
    public class Way2 : IEquatable<Way2>, Iitems
    {
        public string name { get; set; }
        public int itempriority { get; set; }
        public Way2(string name, int priority)
        {
            this.name = name;
            this.itempriority = priority;
        }

        public bool Equals(Way2 other )
        {
            return other != null && name == other.name && itempriority == other.itempriority;
        }
        public override string ToString()
        {
            return  $"{name} :: {itempriority}";
        }
        public override int GetHashCode()
        {
            return name.GetHashCode()^ itempriority.GetHashCode();
        }
     
        
    }
}
