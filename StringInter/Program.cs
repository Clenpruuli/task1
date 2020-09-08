using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. the app ask for the user´s first name and stores it in a seprate variable
            2. the app ask for the user´s last name and stores it in a seprate variable
            */

            string FirstName;
            string LastName;
            Console.WriteLine("what is your name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("what is your last name");
            LastName = Console.ReadLine();

            //Console.WriteLine("Hello, " + FirstName + " " + LastName);

            Console.WriteLine($"Hello, {FirstName} {LastName}");











        }
    }
}
