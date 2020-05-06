
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
            decimal balanceAfterWithdraw = Program.WithdrawMoney(amountToWithdraw);

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
            decimal balanceAfterWithdraw = Program.WithdrawMoney(smallWithdraw);

            //Assert
            Assert.Equal( originalBalance - smallWithdraw, balanceAfterWithdraw);
        }
        [Fact]
        public void TakeAllTheMoney()
        {
            //Arrange
            decimal totalWithdraw = Program.GetBalance();
            //Act
            decimal balanceAfterWithdraw = Program.WithdrawMoney(totalWithdraw);

            //Assert
            Assert.Equal(0, balanceAfterWithdraw);
        }
        
    } 
}
