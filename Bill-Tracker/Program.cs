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
           
            Console.WriteLine("Hello World!");

        }
    }

    class Bill
    {
  
        private string name;
        private double monthlyCost;
        private double annualCost;

        // days in a billing cycle
        private int period;

        // days left until billed
        private int daysLeft;

        // TODO constructor

        // TODO get/set functions

    }

    class User
    {
        private string name;
        private string password;

        // array of bill objects to store
        // TODO will probably change to a linkedlist for scalability
        private Bill[] Bill;

        // TODO constructor

        // TODO get/set functions
    }
}
