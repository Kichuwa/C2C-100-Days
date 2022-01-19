using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Day 1 [01-18-2022]: learning through the week!
//Basics in C# are relative to Java. This should speed up the process.
//I've been using java for a couple years and am moving foraward with other languages as well.
//Today's goal was setting up my IDE and writing a "Hello World"
namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Darren";


            Console.WriteLine("Hello all! My name is " + name + "\n" +
                "This is my first use of C#. \n" + 
                "Welcome to my Day 1 of 100 days learning C#");
            Console.Read();
        }
    }
}
