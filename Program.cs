// Bill Tracking Application
// Created by Ahmed Khan and Lucas Stoltman
// 2020
using System;

namespace Bill_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[1];
            string[] password = new string[1];
            string input;
            name[0] = "Blank";
            password[0] = "Blank";
            introduction(name,password);
            User userOne = new User(name[0], password[0]);
            Console.WriteLine("Would you like to exit? ");
            Console.WriteLine("if yes click 0 or write No ");
            input = Console.ReadLine();
            while (input != "No")
            {
                Console.WriteLine("Would you like to exit? ");
                Console.WriteLine("if yes click 0 or write No ");
                input = Console.ReadLine();
                Console.WriteLine("Ok bye " + name[0] + " ");
            }
            


        }

        public static void introduction(string[] name, string[] password)
        {
            Console.WriteLine("Please Enter your name! ");
            name[0] = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Hello " + name[0] + "please enter a password");
            password[0] = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Thank you for the input we are getting everything started for you");
        }
    }
}
