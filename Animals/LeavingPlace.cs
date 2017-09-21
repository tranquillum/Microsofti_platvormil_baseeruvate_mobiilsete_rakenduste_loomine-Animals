using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class   LeavingPlace
    {
        private  List<Animal> animals = new List<Animal>();
        public virtual  void AddAnimals(Animal animal)
        {
            animals.Add(animal);
        }

        public int GetAnimalCount()
        {
            return animals.Count;
        }



        public int GetCatCount()
        {
            int count = 0;
            foreach (var animal in animals)
            {
                if (animal.GetType().Name == "Cat")
                    count++;
            }
            return count;
        }

        public int GetAnimalCount(string animalType)
        {
            int count = 0;
            foreach (var animal in animals)
            {
                if (animal.GetType().Name == animalType)
                    count++;
            }
            return count;
        }
    }
}
