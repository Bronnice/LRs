using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LR
{
    class Program
    {
        static void Main()
        {
            RedheadDuck duck1 = new RedheadDuck();
            MallardDuck duck2 = new MallardDuck();
            RubberDuck duck3 = new RubberDuck();
            DecoyDuck duck4 = new DecoyDuck();

            List<Duck> ducks = new List<Duck> { duck1, duck2, duck3, duck4 };

            for (int duck = 0; duck < ducks.Count; duck++)
            {
                Console.WriteLine(ducks[duck].Swim());
                Console.WriteLine(ducks[duck].Display());
                if (ducks[duck] is IQuackBehavior)
                {
                    Console.WriteLine((ducks[duck] as IQuackBehavior).Quack());
                }
                if (ducks[duck] is IFlyBehavior)
                {
                    Console.WriteLine((ducks[duck] as IFlyBehavior).Fly());
                }

            }

            Console.ReadKey();
        }
    }
}
