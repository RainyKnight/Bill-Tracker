using System;
using System.Collections.Generic;
using System.Text;

namespace Bill_Tracker
{
    public class UserList
    {
        private User[] userList;
        private int receipt = 0;

        // constructor
        public UserList()
        {
            
        }

        /*
        Function: addUser
        Return Type: int - the receipt # for the specifc user.
        Description: This function allows users to set the receipt for the user 
             they intend to add. 
        Input: 
            User - username : The user to be stored
        */
        public int addUser(User username)
        {
            receipt++;
            userList[receipt] = username;
            return receipt;
        }

        /*
        Function: removeUser
        Return Type: void
        Description: This function allows the admin to get rid of the
             user associated with the receipt number they're assigned
        Input: 
            int - receipt : The receipt numbers the user has stored.
        */
        // TODO potential admin class to manage users?
        public void removeUser(int receipt)
        {
            userList[receipt] = null;
        }
    }
}
