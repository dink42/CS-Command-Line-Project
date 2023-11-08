using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
                Console.WriteLine("Choose an option.".PadLeft(10));
                Console.WriteLine("1.Write what you want in life 4 things.".PadLeft(10));
                Console.WriteLine("2.List the things out.".PadLeft(10));
                Console.WriteLine("3.Serch for your goals.".PadLeft(10));
                Console.WriteLine("4.Quit");

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
                                if (searches.ToLower().Contains(item))
                                {
                                    Console.WriteLine(item + " Was found!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry could not find your item");
                                }
                            }
                            Thread.Sleep(4000);
                            Console.Clear();
                            break;

                        case 4:
                            enBoool = false;
                            Console.WriteLine("Thanks for trying this console App out!");
                            Thread.Sleep(3000);
                            
                            break;
                        default:
                            Console.WriteLine("Choose from the three options!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("I dont understand, pls press 1 to enter your wishes!");
                }
            }
        }
    }
}
