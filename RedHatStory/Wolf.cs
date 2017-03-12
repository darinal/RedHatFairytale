using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public class Wolf : Animal
    {
        public Wolf(string p)
        {
            this.name = p;
        }

        public override void Run(string road)
        {
            Console.Write("А {0} побежал по {1} со всех ног. ", this, road);
        }

        public override void Swallow(Object obj)
        {
            try
            {
                if (obj.GetType() == typeof(GrandMother))
                {
                    GrandMother grandmother = obj as GrandMother;
                    string awfulAction = String.Format("{0} проглотил {1}", this, grandmother);
                    awfulAction = awfulAction.Remove(awfulAction.Length - 1);
                    awfulAction += "у";
                    Console.Write(awfulAction);
                }
                else
                {
                    if (obj.GetType() == typeof(RedHat))
                    {
                        RedHat redHat = obj as RedHat;
                        Console.Write(String.Format("{0} успела только закричать, как {1} проглотил её.\n", redHat, this));
                    }
                    else
                    {
                        throw new UnknownCharacterException();
                    }
                }
            }
            catch (UnknownCharacterException ex)
            {
                Console.WriteLine("{0} не будет этого есть ({1})", this, ex.Message);
            }
        }
    }
}
