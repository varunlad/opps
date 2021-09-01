using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class polymorphism //BASE CLASS
    {
        public virtual void FruitColour()
        {
            Console.WriteLine("Every Fruit has different colour");

        }
    }

    class apple : polymorphism //CHILD CLASS
    {
        public override void FruitColour()
        {
            Console.WriteLine("Apple is red in colour");

        }
    }

    class mango : polymorphism //CHILD CLASS
    {
        public override void FruitColour()
        {
            Console.WriteLine("Mango is yellow in colour");

        }
    }

    class fruits
    {
        static void Main(string[] args) //MAIN METHOD
        {
            polymorphism myobj1 = new polymorphism();
            polymorphism myobj2 = new mango();
            polymorphism myobj3 = new apple();

            myobj1.FruitColour();
            myobj2.FruitColour();
            myobj3.FruitColour();
            Console.ReadLine();
        }
    }
}
