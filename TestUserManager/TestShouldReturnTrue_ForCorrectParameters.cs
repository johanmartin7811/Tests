using System;
using Xunit;
using LAB3;

namespace TestUserManager
{
    public class TestShouldReturnTrue_ForCorrectParameters
    {
        private string user1 = "userName"; private string pass1 = "oldPassword";  private string pass2 = "newPassword";

        [Fact]
        
        public void ShouldReturnTrue_ForCorrectParameters()
        {
            // arrange
           
            UserManager userManager = new UserManager(user1, pass1);
            Boolean result = false;

            // act
            result = userManager.ChangePassword(user1, pass1, pass2);

            // assert
            Assert.True(result);
        }

      

      
    }
}

