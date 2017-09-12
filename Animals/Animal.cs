using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        private string name;
        private int age;

        public string Breed { get; set; }

        public int Age
        {

            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("VIGA: Vanus on liiga väike");
                }
                else if (value > 25)
                {
                    Console.WriteLine("VIGA: Vanus on liiga suur");
                }
                else
                {
                    age = value;
                }
            }

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        //overloading 
        public virtual void Eat( int howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                Console.WriteLine("Eating");
            }

            
        }

        public void Eat( int howManyTimes, string food)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                Console.WriteLine("Eating "+food);
            }

            
        }

        public void Eat()
        {
            
                Console.WriteLine("Eating food");
            

        }
        public virtual void Drink()
        {
            Console.WriteLine("Drinking");
        }

        

        public void SetAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("VIGA: Vanus on liiga väike");
            }
            else if (age > 25)
            {
                Console.WriteLine("VIGA: Vanus on liiga suur");
            }
            else
            {
                this.age = age;
            }
        }
        public int GetAge()
        {
            return this.age;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Viga: nimi puudub");
            }
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return String.Format("Looma tuup on {0}, nimi on {1}, vanus {2}, touk on {3}", this.GetType().Name, Name, Age, Breed);
        }

        

    }
}
