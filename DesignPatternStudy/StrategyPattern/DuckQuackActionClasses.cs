using Pattern.ICollection;
using System;

namespace Pattern
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
