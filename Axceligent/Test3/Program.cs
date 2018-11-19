using System;
using Test3.Models;
using Test3.Models.Skills;

namespace Test3
{
    class Program
    {
        private static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined

            //Console.ReadLine();
        }

    }
}
