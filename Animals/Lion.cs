using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Lion: WildAnimals
    {
        public void Resting()
        {
            Console.WriteLine("Lovi puhkab");
        }

        public void Hunt()
        {
            Console.WriteLine("Lovi hunting");
        }

        public override void Eat(int howManyAnymals)
        {
            Console.WriteLine("Eating {0} animals", howManyAnymals);
        }
    }
}
