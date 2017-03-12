using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public class GrandMother : Human, IRelative
    {

        public GrandMother(string name): base(name)
        {
        }

        public string MakePresent()
        {
            return "красная шапочка";
        }

        public void LoveRedHat()
        {
            Console.WriteLine("{0} любила её ещё больше. ", this);
        }
    }
}
