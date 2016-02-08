using PatternStrategy.Fly;
using PatternStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatternStrategy.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public DuckBase()
        {
            flyBehaviour = new SimpleFly();
            quackBehaviour = new SimpleQuack();
        }
        public abstract void Display();
        public virtual void Quack()
        {
            quackBehaviour.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("I'm swiming");
        }
        public virtual void Fly()
        {
            flyBehaviour.Fly();
        }
    }
}
