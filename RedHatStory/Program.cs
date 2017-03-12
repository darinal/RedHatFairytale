using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHatStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Author.Print("Жила-была в одной деревне маленькая девочка, такая хорошенькая, что лучше ее и на свете не было. ");
            Mother mother = new Mother("Мама");
            GrandMother grandmother = new GrandMother("Бабушка");
            RedHat redHat = new RedHat("Красная шапочка");
            mother.LoveRedHat();
            grandmother.LoveRedHat();

            string present = grandmother.MakePresent();
            redHat.Attribute = present;

            Author.Print(String.Format("На один из праздников вручила однажды бабушка внучке подарок - это была {0}.", redHat.Attribute));
            Author.Print(String.Format("С тех пор ходила девочка в ней постоянно. Так и прозвали соседи девочку - {0}.\n", redHat.Attribute));

            Console.ForegroundColor = ConsoleColor.Green; 
            Author.Print("Мама собирается печь бабушке пирожки. Сколько? ");
            int pieCount;
            int.TryParse(Console.ReadLine(), out pieCount);
            pieCount = pieCount == 0 ? 1 : pieCount;
            Console.ResetColor();
            Stack<Pie> pieBasket = mother.MakePies(pieCount);

            mother.Speak(String.Format("{0} давно пирожков хотела, пойди ей отнеси. ", grandmother));
            Author.Print(String.Format("{0} взяла корзинку и пошла через лес к дому, где жила {1}. ", redHat, grandmother));

            Wolf wolf = new Wolf("Волк");
            Author.Print(String.Format("По дороге ей встретился {0}. ", wolf));
            wolf.Speak(String.Format("Куда ты идешь, {0}?", redHat));
            redHat.Speak("К бабушке, корзинку с пирожками ей несу.");
            wolf.Speak(String.Format("Я тоже хочу проведать твою бабушку, давай ты пойдёшь по одной дорожке, а я по другой и посмотрим, кто быстрее."));

            Console.ForegroundColor = ConsoleColor.Green;
            Author.Print("Какую дорожку выберет Шапочка: 1 - короткую, 2 - длинную? ");
            int road;
            int.TryParse(Console.ReadLine(), out road);
            RoadType roadType = road == 1 ? RoadType.shortRoad : RoadType.longRoad;

            if (roadType == RoadType.shortRoad)
            {
                Author.Print("Хорошая попытка, но вам её не спасти.\n");
            }
            Console.ResetColor();

            Author.Print(String.Format("{0} и {1} пожали друг другу руки(лапы) и разошлись каждый по своей дорожке. ", redHat, wolf));

            switch (roadType)
            {
                case RoadType.shortRoad:
                    Author.Print(String.Format("{0} пошла по короткой дорожке. ", redHat, roadType));
                    wolf.Run("длинной");
                    break;
                case RoadType.longRoad:
                    Author.Print(String.Format("{0} пошла по длинной дорожке. ", redHat, roadType));
                    wolf.Run("короткой");
                    break;
                default:
                    break;
            }
            
            Author.Print(String.Format("Добежав первым и обманом забравшись в дом, "));
            wolf.Swallow(grandmother);
            Author.Print(" и улёгся вместо неё в кровать.\n");
            Author.Print(String.Format("Скоро и {0} подошла к домику, постучалась, представилась. ", redHat));
            bool isThinVoice = true;
            wolf.Speak("Дёрни за верёвочку - дверь откроется!", isThinVoice);
            Author.Print(String.Format("{0} зашла внутрь, но поняла: что-то было не так. {1} показалась ей подозрительной, тогда ", redHat, grandmother));
            redHat.Speak(String.Format("{0}-{0}, почему у тебя такие большие уши?", grandmother));
            wolf.Speak("Чтобы лучше тебя слышать, дитя моё. ", isThinVoice);
            redHat.Speak(String.Format("{0}-{0}, почему у тебя такие большие глаза?", grandmother));
            wolf.Speak("Чтобы лучше тебя видеть.", isThinVoice);
            redHat.Speak(String.Format("{0}-{0}, почему у тебя такие большие зубы?", grandmother));
            wolf.Speak("Чтобы тебя съесть!");
            wolf.Swallow(redHat);

            Console.ForegroundColor = ConsoleColor.Green;
            Author.Print("Нам понадобятся охотники, сколько их будет?");
            int hunterCount;
            int.TryParse(Console.ReadLine(), out hunterCount);
            hunterCount = hunterCount > 1 ? hunterCount : 2;
            Console.ResetColor();
            HuntersGroup huntersGroup = new HuntersGroup(hunterCount);

            Author.Print("На крик прибежали охотники и ");
            huntersGroup.Cut(ref wolf);

            Author.Print(String.Format("И вышли из брюха {0} и {1} - целые и невредимые. Они пригласили спасителей за стол и кончатеся сказка тем, что сидят счастливые {0}, {1}, ", redHat, grandmother));
            foreach (Hunter hunter in huntersGroup)
            {
                Author.Print(String.Format("{0}, ", hunter));
            }
            Author.Print("едят пирожки: ");
            int count = 0;
            while(pieBasket.Count > 0)
            {
                count++;
                pieBasket.Pop();
            }
            Author.Print(String.Format("все {0} шт.\n", count));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Author.Print("Конец");
            Console.ReadKey();
        }
    }
}
