namespace Bill_Tracker
{
    public class Bill
    {
        private int period;
        private int daysLeft;
        private string name;
        private double monthlyCost;
        private double annualCost;

        /*
        Function: Bill 
        Return Type: None
        Description: This constructor initializes the private variables,
                     and creates a constructor if the front end user would
                     like to instantiate a object. 
        Input: 
            string - name : The name of the bill the user wants to set

            double - monthlyCost : The monthly cost of the bill 

            double - annualCost : The yearly cost of the bill 

            int - daysLeft : the daysLeft before the user will resubscribe 
                             with regards to the bill

            int period : The period in which the the bill is setto be renewed.
        */
        public Bill(string name, double monthlyCost, double annualCost, int daysLeft, int period)
        {
            this.name = name;
            this.monthlyCost = monthlyCost;
            this.annualCost = annualCost;
            this.period = period;
        }


        /*
        Function: setName
        Return Type: None
        Description: This function allows users to set the name for the bill 
                     they intend to add. 
        Input: 
            string - name : The name of the bill the user wants to set
        */
        public void setName(string name)
        {
            this.name = name;
        }

        /*
        Function: getName
        Return Type: string - the name of the bill 
        Description: This function allows users to get the name for the bill they 
                     added. 
        Input: none 
        */
        public string getName()
        {
            return name;
        }

        /*
        Function: setMonthlyCost 
        Return Type: void
        Description: This function allows users to set the name for the bill 
                     they intend to add for a monthly costing subscription. 
        Input: double - monthlyCost : monthly cost of bill / subscription
        */
        public void setMonthlyCost(double monthlyCost)
        {
            this.monthlyCost = monthlyCost;
        }

        /*
        Function: getMonthlyCost 
        Return Type: double - monthlyCost for subscription 
        Description: This function allows users to get the name for the bill they
                     intend to use for a monthly costing subscription.
        Input: none
        */
        public double getMonthlyCost()
        {
            return monthlyCost;
        }

        /*
        Function: setannualCost 
        Return Type: void
        Description: This function allows users to set the name for the bill they
                     intend to use for a annual subscription.
        Input: double - annualCost : annualCost of subscription / bill 
        */
        public void setannualCost(double annualCost)
        {
            this.annualCost = annualCost;
        }

        /*
        Function: getannualCost 
        Return Type: double - annual cost of subscription 
        Description: This function allows users to get the name for the bill they
                     intend to use for a annual subscription.
        Input: none
        */
        public double getannualCost()
        {
            return annualCost;
        }

        /*
        Function: setPeriod
        Return Type: void
        Description: This function allows users to set the period for the bill
                     they intend to use for a annual or monthly subscription.
        Input: int - period : period of subscription 
        */
        public void setPeriod(int period)
        {
            this.period = period;
        }

        /*
        Function: getPeriod
        Return Type: int - the period of for the bill the user intended to use
                           for the bill / subscription 
        Description: This function allows users to get the period for the bill
                     the user intend to use for a annual/monthly subscription.
        Input: none
        */
        public int getPeriod()
        {
            return period;
        }


        /*
        Function: setdaysLeft
        Return Type: void 
        Description: This function allows users to set the days left for the 
                     bill the user intend to use for 
                     a annual/monthly subscription.
        Input: int daysLeft 
        */
        public void setdaysLeft(int daysLeft)
        {
            this.daysLeft = daysLeft;
        }

        /*
        Function: getdaysLeft
        Return Type: int - number of days left on subscription / bill
        Description: This function allows users to get the days left for the 
                     bill the user intend to use for 
                     a annual/monthly subscription.
        Input: none 
        */
        public int getdaysLeft()
        {
            return daysLeft;
        }
    }
}

