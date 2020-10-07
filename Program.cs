using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rougelike
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you Stranger?");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("I will still call you Stranger, then.");
                name = "Stranger";
            }
            else if (name.ToLower() == "stranger")
            {
                Console.WriteLine("Ha, I knew it!");
            }
            Console.WriteLine($"Hello {name}.");
            Console.WriteLine("Where are you from "+ name +"?");
            string place = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(place))
            {
                Console.WriteLine("You are not too talkative, are you?");
                place = "Nowhere";
            }
            Console.WriteLine($"Welcome to Moai {name} from {place}.");
            Console.WriteLine("press any key to continue....");
            Console.ReadKey(true);

            string[] level = {
             "#############",
             "#......#....#",
             "#......#....#",
             "#......#....#",
             "#......#....#",
             "#......#....#",
             "#......#....#",
             "#...........#",
             "#......#....#",
             "#############"
            };

            string[] scroll =
            {
            "     _______________",
            "()==(              (@==()",
            "     '______________'|",
            "       |             |",
            "       |             |",
            "     __)_____________|",
            "()==(              (@== ()",
            "     '--------------'",
             "                     PjP"
            };
            Console.Clear();
            Console.WriteLine("Wanna see the map? Press any key until it is revealed....");
            //ujawnienie mapy oraz wczytanie zwoju korzystając ze zmiennej lineIndex
            // int lineIndex = 0;
            // while (lineIndex <9 /2)
            //  {
            //      Console.WriteLine(scroll[lineIndex]);
            //      lineIndex++;
            //  }
            int scrollHalf = scroll.Length / 2;

            for (int index = 0; index < scrollHalf; index++)
            {
                Console.WriteLine(scroll[index]);

            }
            int nextMapRowPosition = Console.CursorTop;
            foreach (string row in level)
            {

                Console.SetCursorPosition(0, nextMapRowPosition);
                Console.WriteLine($"       |{row}|");
                for (int index = scrollHalf; index < scroll.Length; index++)
                {
                    Console.WriteLine(scroll[index]);
                }
                nextMapRowPosition++;
                Console.ReadKey(true);
            }
            //while (lineIndex<9)
           // {
           //     Console.WriteLine(scroll[lineIndex]);
           //     lineIndex++;
           // }
           
            
            Console.ReadKey(true);
            /*
             ##############
             #.......#....#
             #.......#....#
             #.......#....#
             #.......#....#
             #.......#....#
             #.......#....#
             #............#
             #.......#....#
             ##############
                _______________
            ()==(              (@==()
                 '______________'|
                   |             |
                   |             |
                 __)_____________|
            ()==(               (@==()
                 '--------------'
                                  PjP


             */
        }
    }
}
