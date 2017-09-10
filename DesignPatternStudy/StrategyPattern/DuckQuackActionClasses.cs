using DesignPattern.ICollection;
using System;

namespace DesignPattern
{
    class DuckMuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine(".....");
        }
    }

    class DuckCrazyQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("alwejrklajsdflkjsaifsd");
        }
    }
}
