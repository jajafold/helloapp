using System;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone!");
            GreetBlack();
            GreetWhite();
            Console.ReadLine();
        }

        public static void GreetWhite() {
            Console.WriteLine("Hello White");
        }

        public static void GreetBlack() {
            Console.WriteLine("Hello Black");
        }
    }

}