using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            myClass myclass = new myClass("Simon", "Denmark", 2730);

            Console.WriteLine($" Navn: {myclass.Name}");
            Console.WriteLine($" Address: {myclass.Address}");
            Console.WriteLine($" postNr: {myclass.postNr}");
            


        }
    }
}
