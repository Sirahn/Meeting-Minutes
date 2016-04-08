using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Meeting_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int pickOne = 0;
            while (pickOne != 3)
            {
                
                Console.WriteLine ("Meeting Minutes Management Software");
                Console.WriteLine("\n***********************************");
                Console.WriteLine("\nMENU");
                Console.WriteLine("1.CREATE MEETING");
                Console.WriteLine("2.VIEW TEAM");
                Console.WriteLine("3.EXIT");
                Console.Write("Please make menu selection(Ex. Enter -> 1 or 2):  ");
                

                pickOne = int.Parse(Console.ReadLine());
                switch (pickOne)
                {
                    case 1:
                        StreamWriter newstuff = new StreamWriter("Mintues050116.txt");
                        newstuff.WriteLine("Good Day Grocery" + "2334 Mark Lane" + "Meeting Minutes");
                        Console.WriteLine("Who recorded meeting minutes?:  ");
                        Console.ReadLine();
                        Console.WriteLine("Who was leading the meeting?:  ");
                        Console.ReadLine();
                        Console.WriteLine("What is the date of the meeting?:  ");
                        Console.ReadLine();
                        Console.WriteLine("What type of Meeting?:  ");
                        break;


                   
                }



            }
        }
    }
}
