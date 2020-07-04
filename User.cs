using System;
using System.Collections.Generic;
using System.Text;


namespace Bill_Tracker
{
    public class User
    {
        private string name;
        private string password;
        private Bill[] Bill;
        private int receipt = 0;

        /*
        Function: User 
        Return Type: None
        Description: This constructor initializes the private variables,
                     and creates a constructor if the front end user would
                     like to instantiate a object for himself.
        Input: 
            string - name : The name the user wants to set.

            string - password : the password set by the user.

            int numberofBills : The num
        */
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }


        /*
        Function: addBill
        Return Type: int - the receipt # for the specifc bill.
        Description: This function allows users to set the receipt for the bill 
                     they intend to add. 
        Input: 
            Bill - personalBill : The users personal bill 
        */
        public int addBill(Bill personalBill)
        {
            receipt++;
            Bill[receipt] = personalBill;
            return receipt;
        }


        /*
        Function: removeBill
        Return Type: void
        Description: This function allows users to get rid of the
                     bill associated with the receipt for the bill 
                     they intend to remove.
        Input: 
            int - receipt : The receipt numbers the user has stored.
        */
        public void removeBill(int receipt)
        {
            Bill[receipt] = null;
        }

        /*
        Function: setName
        Return Type: void
        Description: This function allows user to set his name up.
        Input: string - name: the name of the user
        */
        public void setName(string name)
        {
            this.name = name;
        }

        /*
        Function: getName
        Return Type: string - the name will be returned
        Description: This function allows user to get his set name back.
        Input: none.
        */
        public string getName()
        {
            return name;
        }

        /*
            Function: setPassword
            Return Type: void
            Description: This function allows user to set his password up.
            Input: string - password: the name of the password
        */
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
