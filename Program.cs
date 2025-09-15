using System;

namespace StudioTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");






            Random rand = new Random();
            int haha = rand.Next(1, 11);
            Console.WriteLine("Press Enter to get a random number");
            Console.WriteLine(haha);
            Console.WriteLine("Wow thats pretty cool");

            Console.WriteLine("And Github!");
            Console.WriteLine("why GitHub :( why merge conflict");

            switch (haha)
            {
                case 2:
                    Console.WriteLine("2 is a Prime Number");
                    break;

                case 3:
                    Console.WriteLine("3 is a Prime Number");
                    break;

                case 5:
                    Console.WriteLine("5 is a Prime Number");
                    break;

                case 7:
                    Console.WriteLine("7 is a Prime Number");
                    break;

                default:
                    Console.WriteLine("Not a Prime Number");
                    break;

            }
            Console.ReadLine();
        }
    }
}
