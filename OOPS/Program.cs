using OOPS.OOPS;
using OOPSAnimal.OOPS;
//using OOPSdog.OOPS;
using OOPSenc.OOPS;
using OOPSOverload.OOPS;
using OOPSoverride.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car tata = new Car();
            //tata.model = "Indica";
            //tata.colour = "White";

            //Car toyota = new Car();
            //toyota.model = "Innova";
            //toyota.colour = "Black";

            //Car maruthi = new Car();
            //maruthi.model = "Swift";
            //maruthi.colour = "White";

            //tata.Run();
            //toyota.Run();
            //maruthi.Run();


            //Dog dog = new Dog();
            //dog.Run();
            //dog.sound();

            //Encap data = new Encap();
            //data.Name = "XYZ";
            //data.Age = "20";

            //Console.WriteLine("Name: " + data.Name );
            //Console.WriteLine("Age: " + data.Age);

            //Overloading Sum = new Overloading();
            //Sum.Add(10, 20);
            //Sum.Add(10, 20, 30);

            Dog dog = new Dog();
            dog.Sound();

            Puppy pup = new Puppy();
            pup.Sound();

            Console.ReadLine();

        }
    }
}
