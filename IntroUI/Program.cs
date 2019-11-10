using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                FirstName = "Seth",
                LastName = "NeJame",
                Age = 33
            };

            Console.WriteLine($"{ p.FirstName } { p.LastName } is my name.");
            Console.WriteLine($"I am { p.Age } years old.");

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a test.");
        }
    }
}
