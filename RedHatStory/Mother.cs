using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public class Mother: Human, IRelative
    {
        public Mother(string name) : base(name)
        {
        }
        public new void Speak(string message)
        {
            Console.WriteLine("и вручила в руки дочки со словами:\n- {1}", this, message);
        }

        public void LoveRedHat()
        {
            Console.Write("{0} любила её без памяти, ", this);
        }

        public Stack<Pie> MakePies(int pieCount)
        {
            Stack<Pie> pieBasket = new Stack<Pie>();

            Random rand = new Random(DateTime.Now.Millisecond);
            Console.Write("Испекла мама однажны пирожков: ");

            for (int i = 0; i < pieCount; i++)
			{
                Pie pie = new Pie();
                pie.IsTasty = rand.Next()%2 == 0 ? true : false;
                Console.Write("{0}-й {1}, ", i + 1, pie.IsTasty ? "вкусный" : "невкусный");
			    pieBasket.Push(pie);
			}
            Console.Write("положила их в корзинку ");
            return pieBasket;
        }
    }
}
