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
        static decimal balance = 1000;
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

        }
    }
}
