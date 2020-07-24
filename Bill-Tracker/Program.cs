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
            introduction(name, password);
            User userOne = new User(name[0], password[0]);
            Console.WriteLine("Would you like to exit? ");
            Console.WriteLine("if yes click 0 or write No ");
            input = Console.ReadLine();
            while (input != "No")
            {
                Console.WriteLine("Would you like to exit? ");
                Console.WriteLine("if yes write \"No\" ");
                input = Console.ReadLine();
                Console.WriteLine("Ok bye " + name[0] + " ");
            }
        }

        public static void introduction(string[] name, string[] password)
        {
            Console.WriteLine("Welcome to the Bill Tracker!");
            Console.WriteLine("Please Enter your name: ");
            name[0] = Console.ReadLine();
            Console.WriteLine("\nHello {0}, please enter a password:", name[0]);
            password[0] = Console.ReadLine();
            Console.WriteLine("\nThank you for the input. We are getting everything started for you.");
            //Console.WriteLine(Environment.NewLine + "If at any time you would like to stop, just type \"0\"");
        }
    }
}