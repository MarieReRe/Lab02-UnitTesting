using System;
using System.Globalization;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DeltaV ATM");
            AtmControls();

        }

        //set initial balance for user 
        static decimal balance = 1000.00m;


        public static decimal GetBalance()
        {
            return balance;
        }
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
            foreach (string action in userActionSelection)
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
            if (userInput == "1" || userInput == "one")
            {
                UserBalance();
            }
            else if (userInput == "2" || userInput == "two")
            {
                Console.WriteLine("How much would you like to deposit today?");
                string userDepositInput = Console.ReadLine();
                decimal amountToDeposit = Convert.ToInt32(userDepositInput);
            }
            else if (userInput == "3" || userInput == "three")
            {
                Console.WriteLine("How much would you like to withdraw today?");
                string response = Console.ReadLine();
                decimal amountToWithdraw = Convert.ToInt32(response);
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
        public static void UserBalance()
        {
            Console.WriteLine($"Your balance is {balance}");
        }

        public static decimal UserDeposit( decimal amountToDeposit)
        {
            decimal newUserBalance = 0;
            if(amountToDeposit > 0)
            {
                newUserBalance = balance += amountToDeposit;
            }
            else if( amountToDeposit < 0)
            {
                Console.WriteLine("Sorry, you cannot deposit a negative number");
            }
            else
            {
                Console.WriteLine($"You cannot deposit {amountToDeposit}");
            }
            return newUserBalance;
        }
        public static decimal WithdrawMoney(decimal amountToWithdraw)
        {
           
            if(balance <amountToWithdraw)
            {
                Console.WriteLine($"Sorry insufficient funds, withdraw less than {balance: C2}");
            }
            else if(balance > 0)
            {
                balance-= amountToWithdraw;
            }
            return balance;
        
        }
      
        
       
      

    }

}
