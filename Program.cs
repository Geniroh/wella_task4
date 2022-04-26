using System;

namespace wella_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! and Welcome to lessthan100 app, lets help you check if your sum total is less than 100");
            Console.Write("lessthan100(x, y) Enter your first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("lessthan100(" + firstNum + ",y) Enter your second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double total = firstNum + secondNum;

            if (total < 100)
            {
                Console.WriteLine("lessthan100(" + firstNum + "," + secondNum + ") is true");
            }
            else
            {
                Console.WriteLine("lessthan100(" + firstNum + "," + secondNum + ") is false");
            }
        }
    }
}
