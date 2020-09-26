using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRookieTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Highest floor which doesn't break the egg: " + FindHighestFloor(100));
            Console.ReadKey();
        }

        public static int FindHighestFloor(int floorCount)
        {
            List<int> floors = FloorsWhichDontBreakTheEgg(floorCount);
            int highestFloor = 0;
            int eggCount = 2;

            int i = 1;

            int divider = 2;
            int middleFloor = floorCount / divider;
            while (eggCount > 1)
            {
                if (floors.Contains(middleFloor))
                {
                    divider = divider * 2;
                    if (floorCount % divider == 0)
                    {
                        middleFloor = middleFloor + (floorCount / divider);
                        Console.WriteLine(floorCount);
                        i = middleFloor;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    eggCount--;
                }
            }

            for (; i < floorCount + 1; i++)
            {
                if (eggCount > 0)
                {
                    if (floors.Contains(i))
                    {
                        highestFloor = i;
                    }
                    else
                    {
                        eggCount--;
                    }
                }
                else
                {
                    break;
                }
            }
            return highestFloor;
        }

        public static List<int> FloorsWhichDontBreakTheEgg(int floorCount)
        {
            List<int> floors = new List<int>();
            Random random = new Random();
            int highestFloor = random.Next(0, floorCount + 1);

            for (int i = 1; i < highestFloor + 1; i++)
            {
                floors.Add(i);
            }
            return floors;
        }
    }
}
