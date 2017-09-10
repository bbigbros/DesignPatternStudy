using Pattern.ICollection;
using System;

namespace Pattern.CAction.Flys
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
