using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Program asks for the user`s first and lastname
            2. program asks for user`s year of birth
            3. Program greets the user by their name and displays their age

            */

            string FirstName;
            string LastName;
            Console.WriteLine("what is your name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("what is your last name");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your year of birth?");
            string Userinput;
            Userinput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(Userinput);
            int age = 2020 - YearOfBirth;


            Console.WriteLine($"Hello, {FirstName} {LastName} {age} ");



        }
    }
}
