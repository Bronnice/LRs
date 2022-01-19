using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RedheadDuck : Duck, Flyable, Quackable
    {
        public override string Display()
        {
            return "Display 12" + " " + this.GetType();
        }

        public string Fly()
        {
            return "Fly" + " " + this.GetType();
        }

        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
    }
}
