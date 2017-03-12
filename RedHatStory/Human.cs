using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public abstract class Human
    {
        public string name;

        public Human(string name)
        {
            this.name = name;
        }

        public void Speak(string message)
        {
            Console.WriteLine("{0} сказал:\n- {1}", this, message);
        }

        public void Went(string where)
        {
            Console.WriteLine("{0} пошёл ", this);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
