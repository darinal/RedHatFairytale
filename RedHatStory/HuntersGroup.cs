using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public class HuntersGroup : IEnumerable
    {
        private Hunter[] hunters;

        public HuntersGroup(int hunterCount)
        {
            hunters = new Hunter[hunterCount];
            InitializeHunters();
        }

        private void InitializeHunters()
        {
            for (int i = 0; i < hunters.Length; i++)
            {
                Hunter hunter = new Hunter(String.Format("Охотник {0}", i+1));
                hunters[i] = hunter;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < hunters.Length; i++)
            {
                yield return hunters[i];
            }

        }

        public void Cut(ref Wolf wolf)
        {
            Console.Write(String.Format(" разрубили {0}y брюхо. ", wolf));
            wolf = null;

        }
    }
}
