using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat siam = new Cat();
            siam.SetName("Miisu");
            siam.SetAge(13);
            siam.SetName("");
            siam.Name = "Miisu";
            siam.Age = 13;

            Console.WriteLine("Kassi nimi on: " + siam.Age);
            Console.WriteLine("Kassi nimi on: " + siam.Name);
            Console.WriteLine("Kassi nimi on: " + siam.GetName());
            Console.WriteLine("Kassi vanus on: " + siam.GetAge());
            siam.Eat();
            siam.Drink();
            
            
            // siam.age = 2;

            Cat angora = new Cat();
            // angora.name = "Liisu";
            // angora.age = -270;
            angora.Drink();
            angora.Name = "Kittikene";

            Dog buldog = new Dog();
            buldog.Name = "Pauk";
            buldog.Age = 4;
            buldog.Eat();
            buldog.Drink();


            Toy toy = new Toy();
            Manufacture manufacture = new Manufacture();
            manufacture.Name = "Disney";
            manufacture.Adress = "Kabi 2, Tartu";

            toy.Color = "blue";
            toy.Manufacture = manufacture;
            toy.Model = "hiir";
            toy.Name = "Mikey";

            angora.FavoriteToy = toy;
            siam.FavoriteToy = toy;
            siam.FavoriteToy = new Toy();
            siam.FavoriteToy.Manufacture = new Manufacture();
            siam.FavoriteToy.Model = "Some model";
            siam.FavoriteToy.Name = "Minni";
            siam.FavoriteToy.Manufacture.Name = "Disney";
            siam.FavoriteToy.Manufacture.Adress = "Kabi 2, Tallinn, 12352";

            Cat persian = new Cat
            {
                Name = "kity",
                Age = 4,
                FavoriteToy = new Toy()
                {
                    Model= "Some model",
                    Name = "Minni",

                    Manufacture = new Manufacture()
                    {
                        Adress = "Kabi 2, Tallinn, 12352",
                        Name = "Disney"

                    }
                    
                }
            };
            //persian.FavoriteToy.Manufacture = new Manufacture();
            //persian.FavoriteToy.Model = "Some model";
            //persian.FavoriteToy.Name = "Minni";
            //persian.FavoriteToy.Manufacture.Name = "Disney";
            //persian.FavoriteToy.Manufacture.Adress = "Kabi 2, Tallinn, 12352";
            siam.Breed = "Siam";


            Console.WriteLine("Kassi nimega {0}, lemmik manguasi on toodetud {1}  poot ja selle manguasi nimi on {2}", persian.Name, persian.FavoriteToy.Manufacture.Name, persian.FavoriteToy.Name );

            buldog.LastSwimmingTime = DateTime.Now;
            

            Console.WriteLine("Koer kais ujumas:{0}", buldog.LastSwimmingTime);

             DateTime dateTime = new DateTime(2017,9,7,9,17,34);
             Console.WriteLine(dateTime);
            dateTime=dateTime.AddDays(2);
            dateTime=dateTime.AddHours(3);
            dateTime = dateTime.AddMinutes(5);
            Console.WriteLine(dateTime);

            Dog tax = new Dog();
            Console.WriteLine(tax.LastSwimmingTime);
            Dog dogi = new Dog("Naki", 4);
            Console.WriteLine(dogi.Name+" "+dogi.Age+" aastane");

            Dog retriver = new Dog(6, "Retriver");
            Console.WriteLine(retriver.Age + " " + retriver.Breed);
            retriver.Eat();
            Console.WriteLine();
            retriver.Eat(10);
            retriver.Eat(3, "fish");
            retriver.Eat(3, "Meat");
            retriver.Name = "laika";

            Console.WriteLine(siam.ToString());
            Console.WriteLine(retriver.ToString());
            Lion leo = new Lion();
            leo.Name = "Simba";
            leo.Breed = "black lion";
            leo.Age = 4;
            Console.WriteLine(leo.ToString());
            leo.Eat(4);

            Cat[] cats = new Cat[3];
            cats[0] = siam;
            cats[1] = angora;
            cats[2] = persian;
            
            //prindi valja koigi kasside nimed
            for (int i = 0; i < cats.Length; i++)
            {
                Console.WriteLine(cats[i].Name);
            }
            //prindi valja koige vanem kassi
            int maxAge = cats[0].Age;
            string name = cats[0].Name;
            for (int i = 0; i < cats.Length; i++)
            {
                if(cats[i].Age>maxAge)
                {
                    maxAge = cats[i].Age;
                    name = cats[i].Name;
                }

            }
            Console.WriteLine(name);//
            //
            Animal animalOne = new Cat();
            Animal animalTwo = new Dog();
            Animal[] animals = new Animal[3];
            animals[0] = animalOne;
            animals[1] = animalTwo;
            animals[2] = angora;
            Pet petOne = new Cat();
            Pet petTwo = new Dog();

            Pet[] pets = new Pet[3];

            pets[0] = petOne;
            pets[1] = petTwo;
            pets[2] = tax;

            Console.WriteLine(animals[0].ToString());

            Cat cat =(Cat) animals[0];
            Console.WriteLine();
            int number = (int)3.4;
            double numberTwo = 2.6;
            number = (int)numberTwo;
            numberTwo = number;

            List<Animal> animallist = new List<Animal>();
            animallist.Add(persian);
            animallist.Add(tax);
            animallist.Add(leo);

            foreach (var animal in animallist)
            {
                Console.WriteLine(animal.ToString());
            }
            Console.WriteLine();

            animallist.Remove(persian);
            foreach (var animal in animallist)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine();
            animallist.RemoveAt(0);

            foreach (var animal in animallist)
            {
                Console.WriteLine(animal.ToString());
            }

            Zoo zoo = new Zoo();
            zoo.AddAnimals(angora);
            zoo.AddAnimals(tax);
            zoo.AddAnimals(leo);

            Console.WriteLine("Loomaajas on {0} looma", zoo.GetAnimalCount());

            Console.WriteLine("Loomaajas on {0} lovi", zoo.GetAnimalCount("Lion"));

            Console.WriteLine();
            Console.WriteLine();

            Farm farm = new Farm();
            farm.AddAnimals(angora);
            Console.WriteLine("Loomaajas on {0} looma", farm.GetAnimalCount());

            Console.WriteLine();
            Console.WriteLine();

            farm.AddAnimals(leo);//ebaonnestu

            Console.ReadLine();
        }
    }
}
