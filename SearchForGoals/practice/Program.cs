using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enBoool = true;
            
            string[] miArray = new string[4];
            while (enBoool == true)
            {
                Console.WriteLine("Choose an option.");
                Console.WriteLine("1.Write what you want in life 4 things.");
                Console.WriteLine("2.List the things out.");
                Console.WriteLine("3.Serch for your goals.");

                int userChoise;

                if (int.TryParse(Console.ReadLine(), out userChoise) == true)
                {
                    switch (userChoise)
                    {
                        case 1:
                            Console.WriteLine("Write them in! ");
                            for (int i = 0; i < miArray.Length; i++)
                            {
                                miArray[i] = Console.ReadLine();
                            }
                            break;

                        case 2:
                            foreach (var item in miArray)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter what you looking for ");
                            string searches = Console.ReadLine();

                            foreach (var item in miArray)
                            {
                                if (searches.ToUpper() == item.ToUpper())
                                {
                                    Console.WriteLine(item + " Was found!");
                                }
                            }

                            break;

                        default:
                            Console.WriteLine("Choose from the menu!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("I dont understand, pls press 1 or 2!");
                }
            }
        }
    }
}
