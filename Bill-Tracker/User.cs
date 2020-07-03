using System;
using System.Collections.Generic;
using System.Text;


namespace Bill_Tracker
{
    public class User
    {
        private string name;
        private string password;
        private int numberofBills;
        private Bill[] Bill;

        public User(string name, string password, int numberofBills)
        {
            this.numberofBills = numberofBills;
            this.name = name;
            this.password = password;
        }

        public void addBill(int numberofBills)
        { 
            Bill[] temp = new Bill[numberofBills + 1];
            temp = Bill;
        }



        // TODO get/set functions
    }
}
