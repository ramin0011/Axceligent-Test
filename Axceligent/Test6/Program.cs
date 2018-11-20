using System;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class Program
    {
        private static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();

            myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(myHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            //before build the house description still is as before
            //kitchen, master room, guest room, balcony
            Console.WriteLine(myHouse.Describe());
            myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(myHouse.Describe());

            Console.ReadLine();
        }


    }
}
