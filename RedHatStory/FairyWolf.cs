using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    public static class FairyWolf
    {
        public static void Speak(this Wolf wolf, string meassage)
        {
            Console.WriteLine("{0} сказал:\n- {1}", wolf, meassage);
        }

        public static void Speak(this Wolf wolf, string meassage, bool isGrandmotherVoice)
        {
            Console.WriteLine("{0} ответил тоненьким голосом:\n- {1}", wolf, meassage);
        }
    }
}
