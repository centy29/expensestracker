using System.Transactions;

namespace expenses_tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EXPENSES TRACKER");

            //login
            double money = 0.0;
            string name = "centy";

            Console.Write("enter your name: ");
            string username = Console.ReadLine();

            //OPTIONS
            if (username == name)
            {
                Console.WriteLine("LOGGED IN...");

                string[] options = { "1. add", "2. pay", "3. history", "4. exit" };
                Console.WriteLine("OPTIONS");

                //looping

                foreach (var option in options)
                {
                    Console.WriteLine(option);

                }
                Console.WriteLine("ENTER AN OPTION");
                int useroption = Convert.ToInt16(Console.ReadLine());

                switch (useroption)
                {

                    case 1:
                        Console.WriteLine("ENTER AMOUNT TO ADD");
                        double toadd = Convert.ToInt16(Console.ReadLine());

                        money += toadd;
                        Console.WriteLine($"YOUR NEW BALANCE IS: {money}");
                        break;

                    case 2:
                        Console.WriteLine("ENTER AMOUNT TO PAY");
                        double topay = Convert.ToInt16(Console.ReadLine());

                        money -= topay;
                        Console.WriteLine($"YOUR NEW BALANCE IS: {money}");
                        break;

                    case 3:
                        Console.WriteLine($"YOUR MAIN BALANCE IS{money}");
                        break;

                    case 4:
                        Console.WriteLine("THANKS FOR USING EXPENSES TRACKER");
                        break;

                }



            }



            else
            {
                Console.WriteLine("INCORRECT PASSWORD!!!");
            }

        }
    }
}
