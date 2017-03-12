using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public class RedHat : Human
    {
        private string attribute;

        public RedHat(string name) : base(name)
        {

        }

        public string Attribute
        {
            get { return attribute; }
            set { attribute = value; }
        }

        public new void Speak(string message)
        {
            Console.WriteLine("{0} сказалa:\n- {1}", this, message);
        }
        
    }
}
