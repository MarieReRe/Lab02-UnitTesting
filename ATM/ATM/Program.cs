using System;
using System.Globalization;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
           
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
                "4. Exit",

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
                
                UserDepositPrompt();
            }
            else if (userInput == "3" || userInput == "three")
            {
                WithdrawPrompt();
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
            UserChoiceNextRound();
        }

        //Seperate Deposit Prompt and functionality
        public static void UserDepositPrompt()
        {
            try
            {
                decimal previousBalance = balance;
                Console.WriteLine("How much would you like to deposit today?");
                string userDepositInput = Console.ReadLine();
                decimal amount = Convert.ToInt32(userDepositInput);
                balance = UserDeposit(balance, amount);
                Console.WriteLine($"${previousBalance + balance} deposited to your account. Your new balance is now {balance}");
            }
            catch (FormatException formEx)
            {

                Console.WriteLine($"Sorry, wrong input {0}", formEx.Message);
            }
            finally
            {
                UserChoiceNextRound();
            }
        }

        public static decimal UserDeposit(decimal balance, decimal amount)
        {
            
            if (amount > 0)
            {
               
               balance += amount;
            }
            else if (amount == 0)   
            {
               
                Console.WriteLine($"You cannot deposit {amount}");
            }
            else if (amount < 0)
            {
                Console.WriteLine("Sorry, you cannot deposit a negative number");
            }

            return balance;
        }

        //Seperate prompt and actual method.
        public static void WithdrawPrompt()
        {
            try
            {
                decimal previousBalance = balance;
                Console.WriteLine("How much would you like to withdraw today?");
                string response = Console.ReadLine();
                decimal amount = Convert.ToInt32(response);
                balance = WithdrawMoney(balance, amount);
                Console.WriteLine($"${previousBalance - balance} withdrawn from your account. Your new balance is now {balance}");
            }
            catch (FormatException formEx)
            {

                Console.WriteLine($"Sorry, wrong input {0}", formEx.Message);
            }
            finally
            {
                UserChoiceNextRound();
            }
        }

        public static decimal WithdrawMoney(decimal balance, decimal amount)
        {
            if(balance <amount)
            {
                Console.WriteLine($"Sorry insufficient funds, withdraw less than {balance: C2}");
            }
            else if(balance > 0)
            {
                balance-= amount;
            }
            return balance;
        
        }

      


        //Create variable to prompt user again after imputs
        public static void UserChoiceNextRound()
        {

            Console.WriteLine("Is there anything else we can do for you today?");
            Console.WriteLine("Yes/No");

            string response = Console.ReadLine().ToLower();

            if (response == "yes" || response == "y")
            {
                UserChoice();
            }
            else
            {
                Console.WriteLine("Thanks for choosing DeltaV ATM. GoodBye");
            }
        }

        
      
        
       
      

    }

}
