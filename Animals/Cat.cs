﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Pet,IWalker
    {
        public Toy FavoriteToy { get; set; }
        public int LastWalkingDistance { get; set; }

        public void CatchMouse()
        {
            Console.WriteLine("Catcing mouse");
        }

        public string GetWalkingPlaceName()
        {
            return "Backyard";
        }

        public override string ToString()
        {
            string oldTostring = base.ToString();

            return oldTostring + " new";
        }

        public void Walk()
        {
            Console.WriteLine("Walging");
        }

        public void Walk(int meters)
        {
            Console.WriteLine("Walking {0} meetrit", meters);
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


        //       name = value;
        //    }

        //}

        //public void SetAge(int age)
        //{
        //    if (age < 0)
        //    {
        //        Console.WriteLine("VIGA: Vanus on liiga väike");
        //    }
        //    else if (age > 25)
        //    {
        //        Console.WriteLine("VIGA: Vanus on liiga suur");
        //    }
        //    else
        //    {
        //        this.age = age;
        //    }
        //}
        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public void SetName(string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine("Viga: nimi puudub");
        //    }
        //    this.name = name;       
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

        //public void Eat()
        //{
        //    Console.WriteLine("Eating fish");
        //}
        //public void Drink()
        //{
        //    Console.WriteLine("Drinking");
        //}

    }
}
