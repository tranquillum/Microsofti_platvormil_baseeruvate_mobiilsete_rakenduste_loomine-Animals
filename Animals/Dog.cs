using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Pet 
    {

        public DateTime LastSwimmingTime { get; set; }
        public Dog()
        {
            LastSwimmingTime = DateTime.Now;
            Console.WriteLine("Lisati uus koer");
        }
        //constructor Overloading
        public Dog(string name)
        {
            Name = name;

        }
        public Dog (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Dog(int age, string breed)
        {
            Breed = breed;
            Age = age;

        }



        public void CrewBone()
        {
            Console.WriteLine("Crewing bone");
        }

        



        //private string name;
        //private int age;


        //public int Age
        //{

        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            Console.WriteLine("VIGA: Vanus on liiga väike");
        //        }
        //        else if (value > 25)
        //        {
        //            Console.WriteLine("VIGA: Vanus on liiga suur");
        //        }
        //        else
        //        {
        //            age = value;
        //        }
        //    }

        //}

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {


        //        name = value;
        //    }

        //}

        //public void Eat()
        //{
        //    Console.WriteLine("Eating food");
        //}
        //public void Drink()
        //{
        //    Console.WriteLine("Drinking");
        //}


    }
}
