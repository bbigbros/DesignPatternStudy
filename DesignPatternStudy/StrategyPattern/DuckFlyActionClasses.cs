using DesignPattern.ICollection;
using System;

namespace DesignPattern.CAction.Flys
{
    class DuckNonFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I dot't flying...");
        }
    }

    class DuckSlowFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("slow flying...");
        }
    }
}
