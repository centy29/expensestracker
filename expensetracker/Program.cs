using System;
using System.Collections.Generic;// this is needed to recognize the list
using expenses_businesslogic;//method para ma call yung another class sa main class

namespace expenses_tracker
{
    internal class Program
    {

        static string[] options = { "1. ADD EXPENSES", "2. PAYMENT METHOD", "3. HISTORY", "4.EXIT " }; // options for the user

        static void Main(string[] args) //main method nga
        {

            Console.WriteLine("WELCOME TO EXPENSES TRACKER");

            string pin = "centy"; //variable name tsaka pin and username
            string userpin;
            do
            {
                Console.WriteLine("ENTER PIN: ");
                userpin = Console.ReadLine();

                if (userpin != pin)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("ERROR!, ENTER THE CORRCT PIN!");
                }


            } while (userpin != pin);//LOOP UNTIL THE USER ENTERS THE CORRECT PIN

            //DisplayOptions();
            //int userinput = GetUserInput();//this is for the user to input their selected option
            int userinput = 0;

            do
            {
                DisplayOptions();// to display again after executing or finishing an option
                                 //update: dapat matanggal yung invi line for options
                userinput = GetUserInput();
                switch (userinput)
                {
                    case 1:
                        AddExpenses();//TO DISPLAY THE ADD EXPENSE METHOD
                        break;
                    case 2:
                        if (expenselogic.paymentmethod())//DISPLAY IF TRUE
                            RemoveExpense();
                        else
                            Console.WriteLine("ADD AN ITEM BEFORE USING THIS OPTION AGAIN");//DISPLAY IF FALSE
                        break;
                    case 3:
                        history();//TO DISPLAY THE HISTORY INPUT 
                        break;
                    case 4: //exit method
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("THANKS FOR USING EXPENSES TRACKER");
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT PLEASE CHOOSE NUMBER 1 TO 4");//TO REMIND THE USER TO CHOOSE ONLY 1 TO 4 IN OPTIONS
                        break;

                }
            } while (userinput != 4);
        }

        static void DisplayOptions()//easiest method para sa looping ni mam
        {
            Console.WriteLine("----------------========");
            Console.WriteLine("PICK AN OPTION: ");

            foreach (var option in options) //this is used for displaying the list of options
            {
                Console.WriteLine(option);
            }
        }//UI LOGIC
        static int GetUserInput()
        {
            Console.WriteLine("------------------------");
            int userinput = Convert.ToInt16(Console.ReadLine());
            return userinput;// return or loop to make another input
        }//UI LOGIC, pero parang data logic kasi need ng input

        static void RemoveExpense()
        {
            Console.WriteLine("EXPENSE/S PAID! REMOVING THE LATEST INPUT!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("THE LASTEST INPUT HAVE BEEN REMOVED SUCCESSFULLY");
        }

        static void AddExpenses()
        {

            Console.WriteLine("ADD THE EXPENSES DETAILS");

            Console.WriteLine("------------------------");
            Console.WriteLine("ENTER THE BRAND");
            string brand = Console.ReadLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("ENTER THE ADDRESS");
            string address = Console.ReadLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("ENTER TIN ID NUMBER");
            int tin = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("ENTER INVOICE NUMBER");
            int invoice = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("ENTER THE AMOUNT SPENT");
            double amount = Convert.ToInt16(Console.ReadLine());

            expenselogic.expenses.Add((brand, address, tin, invoice, amount));// a method for adding the input from here to store in the list
            Console.WriteLine("-------------------------------");
            Console.WriteLine("THE EXPENSES ADDED SUCCESSFULLY");
            Console.WriteLine("-------------------------------");

            //MORE UPDATE: MAKE IT SAVED TO A DATABASE FOR EASY STORING AND SEE THE STORED DATA
        }// PROCESSING LOGIC BL/DL, BUT MORE LIKELY UI KASI INEENTERTAIN ANG USER


        static void history()
        {
            foreach (var expense in expenselogic.expenses)//USED TO DISPLAY THE LIST OF EXPENSES NA NAINPUT OR NA ADD
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("BRAND: " + expense.brand);
                Console.WriteLine("ADDRESS: " + expense.address);
                Console.WriteLine("TIN: " + expense.tin);
                Console.WriteLine("INVOICE: " + expense.invoice);
                Console.WriteLine("AMOUNT: " + expense.amount);
                Console.WriteLine("-----------------------");
            }
        }// PROCESSING LOGIC BL/DL, AT SOME POINT DISPLAYING LANG SIYA PERO ANG LOGIC NIYA IS KUMUKUHA NG STORED DATA
        //MORE UPDATE: CAN CHOOSE THE ITEM THEY WANT A HISTORY OR SHOWS ALL THE ITEMS STORED IN THE LIST


    }
}

