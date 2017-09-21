using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bear : WildAnimals, IWalker
    {
        public int LastWalkingDistance { get; set; }

        public string GetWalkingPlaceName()
        {
            return "forest";
        }

        public void Walk()
        {
            Console.WriteLine("Walking in forest");
        }

        public void Walk(int meters)
        {
            Console.WriteLine("Walking in forest {0}", meters);
        }
    }
}
