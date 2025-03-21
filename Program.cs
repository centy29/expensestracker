using System;
using System.Transactions;

namespace expenses_tracker
{
    internal class Program
    {
        static void Main(string[] args) //main method nga
        {

            Console.WriteLine("WELCOME TO EXPENSES TRACKER");

            //variables tsaka values tapos pin login

            string pin = "centy";
            string username;

            //looping tsaka creating input

            do
            {
                Console.Write("ENTER YOUR NAME: ");
                username = Console.ReadLine();
                if (username != pin)
                {

                    Console.WriteLine("--------------");
                    Console.WriteLine("LOGGED IN...");

                }
                else {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("WRONG PIN, ENTER THE CORRECT PIN!!!");
                }

            }
            while (username == pin);

                

                    string[] options = { "1. ADD EXPENSES", "2. PAYMENT METHOD", "3. PAYMENT HISTORY", "4.EXIT " };
                    Console.WriteLine("--------------");
                    Console.WriteLine("SELECT AN OPTION");
                    Console.WriteLine("--------------");


                    foreach (var option in options)
                    {
                        Console.WriteLine(option);
                    }
                    Console.WriteLine("ENTER AN OPTION");
                    Console.WriteLine("---------------");

                    int useroption = Convert.ToInt16(Console.ReadLine());

                   while (useroption != 4)
                    {

                        switch (useroption)
                        {

                            case 1:

                                {
                                    AddDetails();
                                }
                                break;

                            case 2:
                                Console.WriteLine(PaymentMethod);
                                Console.WriteLine("");
                                break;

                            case 3:
                                Console.WriteLine(PaymentHistory());
                                Console.WriteLine(" ");
                                break;

                            case 4:
                                Console.WriteLine("THANKS FOR USING EXPENSES TRACKER");

                                break;

                            default:
                                Console.WriteLine("INVALID CHOICE");
                                break;
                        }
                    }

                    foreach (var option in options)
                    {
                        Console.WriteLine(option);
                    }
                    Console.WriteLine("ENTER AN OPTION");
                    Console.WriteLine("---------------");

                    useroption = Convert.ToInt16(Console.ReadLine());

                static void AddDetails() //method for adding details
                {
                    while (true)
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



                    }

                }
                static string PaymentMethod() //methods to remove the money input
                {
                    Console.WriteLine("WHAT IS YOUR PAYMENT METHOD?(CASH OR CREDIT?)");
                    string pay = Console.ReadLine();

                    if (pay == "CASH")
                    {
                        Console.WriteLine("ENTER AMOUNT TO PAY...");
                        double payable = Convert.ToInt16(Console.ReadLine());

                    }

                    return "";
                }
                static string PaymentHistory()
                {
                Console.WriteLine("-----------------");
                Console.WriteLine("BRAND:" );

                Console.WriteLine("-----------------");
                Console.WriteLine("ADDRESS:");

                Console.WriteLine("-----------------");
                Console.WriteLine("TIN:");

                Console.WriteLine("-----------------");
                Console.WriteLine("INVOICE:");

                 Console.WriteLine("----------------");
                Console.WriteLine("AMOUNT: ");
                return " THIS IS THE HISTORY OF YOU LISTS";

                }








            
        }

    } 
}
    
