using System;

namespace CSharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            Console.WriteLine("Display terms: ");
            Console.WriteLine($"${x}+{y}={x + y}");

            Console.WriteLine();

            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"${a}+{b}={a + b}");

            Console.WriteLine();

            Console.WriteLine("Enter two numbers in OOP");
            Addition addObject = new Addition();
            addObject.SetX(Console.ReadLine());
            addObject.SetY(Console.ReadLine());
            addObject.Display();
        }
    }

    internal class Addition
    {
        int x;
        int y;

        public void SetX(string val)
        {
            x = int.Parse(val);
        }

        public void SetY(string val)
        {
            y = int.Parse(val);
        }

        private int GetSummation()
        {
            return x + y;
        }

        public void Display()
        {
            Console.WriteLine($"{x}+{y}={GetSummation()}");
        }
    }


}
