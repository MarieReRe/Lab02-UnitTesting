
using ATM;
using System;
using Xunit;

namespace TestATM
{
    public class TestATM
    {


        [Fact]
        public void doWeHaveBalance()
        {
            //Arrange


            //Act
            decimal balance = Program.GetBalance();

            //Assert
            Assert.Equal(1000, balance);
        }
        [Fact]
        public void NoOverdrafting()
        {
            //set up circumstances
            //arrange
            decimal originalBalance = Program.GetBalance();
            decimal amountToWithdraw = originalBalance + 500;
            //act
            decimal balanceAfterWithdraw = Program.WithdrawMoney(originalBalance, amountToWithdraw);

            //assert
            Assert.Equal(originalBalance, balanceAfterWithdraw);
        }
        [Fact]
        public void CanWithdrawSmallAmount()
        {
            //Arrange
            decimal originalBalance = Program.GetBalance();
            decimal smallWithdraw = originalBalance / 20;
            
            //Act
            decimal balanceAfterWithdraw = Program.WithdrawMoney(originalBalance,smallWithdraw);

            //Assert
            Assert.Equal( originalBalance - smallWithdraw, balanceAfterWithdraw);
        }
        [Fact]
        public void TakeAllTheMoney()
        {
            //Arrange
            decimal originalBalance = Program.GetBalance();
            decimal totalWithdraw = Program.GetBalance();
            //Act
            decimal balanceAfterWithdraw = Program.WithdrawMoney(originalBalance,totalWithdraw);

            //Assert (expect = actual)
            Assert.Equal(0, balanceAfterWithdraw);
        }

        //deposit zero
        [Fact]
        public void DepositOfZero()
        {
            //Arrange
            decimal originalBalance = Program.GetBalance();
            decimal userDepositInput = 0;
           
            //Act
            decimal balanceAfterDeposit = Program.UserDeposit(originalBalance, userDepositInput);
            //Assert
            Assert.Equal(balanceAfterDeposit, userDepositInput);

        }
        //deposit 100
        [Fact]
        public void DepositGreaterThanZero()
        {
            //Arrange
            decimal originalBalance = Program.GetBalance();
            decimal userDepositInput = 100;
           
            //Act
            decimal balanceAfterDeposit = Program.UserDeposit(originalBalance, userDepositInput);

            //Assert
            Assert.Equal(originalBalance + userDepositInput, balanceAfterDeposit);
            Assert.Equal(Program.GetBalance(),balanceAfterDeposit) ;
        }
        // deposit negative number

        [Fact]
        public void UserTriedToDepositANegative()
        {
            //Arrange
            decimal originalBalance = Program.GetBalance();
            decimal userDepositInput = -1;


            //Act
            decimal balanceAfterDeposit = Program.UserDeposit(originalBalance,userDepositInput);

            //Assert
            Assert.Equal(originalBalance, balanceAfterDeposit);
        }
       
        
    } 
}
