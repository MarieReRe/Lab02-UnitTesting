using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DeltaV ATM");
            AtmControls();

        }
        //set initial balance for user 
        static double balance = 10000000.00;
        public static void AtmControls()
        {
            string[] userActionSelection =
            {
                "1. View My Balance",
                "2. Deposit Money",
                "3. Withdraw Money",
                "4. Exit"

            };
            //This will be the contol
            Console.WriteLine("Welcome to DeltaV ATM, Please choose a number to proceed.");

            //iterate through each user selection
            foreach(string action in userActionSelection)
            {
                Console.WriteLine(action);
            }
            try
            {
                UserChoice();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry something went wrong, please return at a later date {0}", ex.Message);
            }

        }
        public static void UserChoice()
        {
            //set the user number choice to string
            string userInput = Console.ReadLine();
            //If user inputs "number x'
            if(userInput == "1" || userInput == "one")
            {
                Console.WriteLine("Testing: You chose option one");
            }
            else if (userInput == "2" || userInput == "two")
            {
                Console.WriteLine("Testing: You chose option two");
            }
            else if (userInput == "3" || userInput == "three")
            {
                Console.WriteLine("Testing: You chose option three");
            }
            else if (userInput == "4" || userInput == "four")
            {
                Console.WriteLine("Testing: You chose option four");
            }
            else
            {
                throw new Exception("Sorry that is not a valid input, please input a number.");
            }
        }
    }

}
