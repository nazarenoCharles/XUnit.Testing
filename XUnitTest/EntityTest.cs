using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Entity;
using Business;


namespace XUnitTest
{
    public class EntityTest
    {
        readonly List<UsersModel> people = new List<UsersModel>();
        
       
        [Theory]
        [InlineData("blazt42","samplepassword","Charles","Nazareno")]
        [InlineData("SampleUser", "anotherpass","Janine", "Minorete")]
        public void User_ShouldAddToTheList(string username, string password, string firstname, string lastname)
        {
            people.Add(ManageUsers.AddingUserandValidation(username, password, firstname, lastname));
            //Assign
            int expect = 1;
            //Act
            int act = people.Count();
            //Assert
            Assert.Equal(act, expect);
        }
        [Fact]
        public void UserDetailsAreNull_Invalid()
        {
            Assert.Throws<ArgumentException>(() => ManageUsers.NameValidaton("", ""));
            Assert.Throws<ArgumentException>(() => ManageUsers.NameValidaton("Sample", ""));
        }

        [Theory]
        [InlineData("Charles ", "  Nazareno  ", "CharlesNazareno")]
        [InlineData(" John", "Wick", "JohnWick")]
        [InlineData(" Micheal", " Jackson   ", "MichealJackson")]
        public void AddingUser_WithCompleteNameDetails(string firstname, string lastname, string fullname)
        {
            string fullnameResult = ManageUsers.NameValidaton(firstname, lastname);
            Assert.Equal(fullname, fullnameResult);
        }

        [Theory]
        [InlineData("", "HasData", "HasData", "HasData", "FirstName")]
        [InlineData("HasData", "", "HasData", "HasData", "LastName")]
        [InlineData("HasData", "HasData", "", "HasData", "UserName")]
        [InlineData("HasData", "HasData", "Hasdata", "", "PassWord")]
        public void UserDetails_NotComplete(string firstname, string lastname, string username, string password, string param)
        {
            Assert.Throws<ArgumentException>(param, () => ManageUsers.AddingUserandValidation(firstname, lastname, username, password));
                
        }

        
        //[Theory]
        //[InlineData("Charles", "selrahC", "selrahC")]
        //public void EditingUser_WillValidateUserName(string username, string UserName, string newuser)
        //{

        //    string newUserName = ManageUsers.EditUser(UserName, username);
        //    Assert.Equal(newUserName, newuser);
        //}
        //[Fact]
        //public void Delete_ValidateIfOkay()
        //{
            
        //}
        [Theory]
        [InlineData("passwordnotvalid", "PassWord")]
        [InlineData("Passwordstillnotvalid", "PassWord")]
        public void PasswordValidation_IsInvalid(string password, string param)
        {
            Assert.Throws<ArgumentException>(param, () => ManageUsers.PasswordValidation(password));
        }

        [Fact]
        public void PasswordValidation_Valid()
        {
            //Assign
            bool checker = true;
            //Act
            bool input = ManageUsers.PasswordValidation("PasswordValid3");
            //Assert
            Assert.Equal(checker, input);
        }
        
    }
}

