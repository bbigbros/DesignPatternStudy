using System;
using Pattern.ICollection;
using Pattern.CAction.Flys;

namespace Pattern
{
    abstract class Duck
    {
        protected IFlyBehavior flybehavior;
        protected IQuackBehavior quackbehavior;

        public Duck(){}

        public void Fly()
        {
            flybehavior.Fly();
        }

        public void Quack()
        {
            quackbehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming..");
        }
        public abstract void Display();
    }

    class RedDuck : Duck
    {
        public RedDuck()
        {
            flybehavior = new DuckSlowFly();
            quackbehavior = new DuckCrazyQuack();
        }
    
        public override void Display()
        {
            Console.WriteLine("I'm RedDuck.....");
        }
    }

    class YelloDuck : Duck
    {
        public YelloDuck()
        {
            flybehavior = new DuckNonFly();
            quackbehavior = new DuckMuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm YellowDuck.....");
        }
    }
}
