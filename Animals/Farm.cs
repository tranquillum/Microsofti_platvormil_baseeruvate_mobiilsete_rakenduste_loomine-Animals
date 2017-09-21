using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Farm:LeavingPlace
    {

        public override void AddAnimals(Animal animal)
        {
            if (animal is FarmAnimals)
            {
                    base.AddAnimals(animal);
            }
            else
                {
                Console.WriteLine("Lisamine ebaonnestu. Farmis saavad elada ainult farmi animals");
                }
        }

    }
}
