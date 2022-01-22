 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract public class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string Swim()
        {
            return "Буль буль буль";
        }
        public string Display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }
        public string performQuack() 
        {
            return quackBehavior.Quack();
        }
        public string performFly()
        {
            return flyBehavior.Fly();
        }

        public IFlyBehavior FlyBehavior
        {
            set { flyBehavior = value; }
        }
        public IQuackBehavior QuackBehavior
        {
            set { quackBehavior = value; }
        }
    }
}
