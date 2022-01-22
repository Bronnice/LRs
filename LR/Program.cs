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

            Console.WriteLine(duck1.GetType() + " до изменения:\n" + duck1.performFly() + " " + duck1.performQuack() + "\n");
            Console.WriteLine("После:");

            duck1.FlyBehavior = new FlyNoWay();
            duck1.QuackBehavior = new Squek();


            List<Duck> ducks = new List<Duck> { duck1, duck2, duck3, duck4 };

            for (int duck = 0; duck < ducks.Count; duck++)
            {
                Console.WriteLine(ducks[duck].Swim());
                Console.WriteLine(ducks[duck].Display());
                Console.WriteLine(ducks[duck].performFly());
                Console.WriteLine(ducks[duck].performQuack());
                Console.WriteLine("\n------------------\n");


            }

            Console.ReadKey();
        }
    }
}
