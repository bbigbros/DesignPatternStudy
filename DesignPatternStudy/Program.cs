using System;

namespace DesignPatternStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            RedDuck rd = new RedDuck();
            rd.Display();
            rd.Fly();
            rd.Quack();
            Console.WriteLine();

            YelloDuck yd = new YelloDuck();
            yd.Display();
            yd.Fly();
            yd.Quack();
            Console.WriteLine();
        }
    }
}
