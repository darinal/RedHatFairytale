using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public abstract class Animal
    {
        public string name;
        public abstract void Run(string road);
        public abstract void Swallow(Object obj);

        public override string ToString()
        {
            return this.name;
        }
    }
}
