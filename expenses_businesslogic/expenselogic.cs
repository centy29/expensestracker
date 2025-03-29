using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses_businesslogic
{
    public class expenselogic
    {
        public static List<(string brand, string address, int tin, int invoice, double amount)> expenses = new List<(string, string, int, int, double)>();//here store the add expenses input
        public static bool paymentmethod()
        {
            if (expenses.Count > 0)
            {
                expenses.RemoveAt(expenses.Count - 1);//BABAWASAN YUN ITEMS NA NASA LIST NG ISA 
                return true;
            }
            else
            {
                return false;//REMINDS THE USER TO ADD ITEM BEFORE USING THI9S OPTION AGAIN
            }
            return true;
        }
        //PROCESSING LOGIC BL/DL
        //MORE UPDATE: THE USER WILL BE REMINDED THE LATEST INPUT IN THE LIST AND CAN CHOOSE WHAT TO REMOVE

    }
}
