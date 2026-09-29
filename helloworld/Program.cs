using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        string name = "Daniel";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("hello world and people of earth and in case i dont see you good afternoon good evening and good night");
            Console.WriteLine("my name is Daniel and i am a student at the University of California, Berkeley");
            Console.WriteLine("my day today was good and i am happy to be here");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName);

        }
    }
}