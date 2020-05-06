using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace TestATM
{
    public class TestATM
    {
        [Fact]
        public void cannot_overdraw_account()
        {
            //Arrange
            double balance = 0;
            double withdrawalAmount = 5;

            //Act
            double result = Program.WithDraw(balance, withdrawalAmount);
            //Assert
            Assert.Equal(0, result);

        }
    }
}
