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
        readonly ManageUsers users = new ManageUsers();
       
        [Theory]
        [InlineData("blazt42","samplepassword","Charles","Nazareno")]
        [InlineData("SampleUser", "anotherpass","Janine", "Minorete")]
        public void User_ShouldAddToTheList(string username, string password, string firstname, string lastname)
        {
            people.Add(users.AddingUser(username, password, firstname, lastname));
            //Assign
            int expect = 1;
            //Act
            int act = people.Count();
            Assert.Equal(act, expect);
        }
        [Fact]
        public void UserDetailsAreNull_InvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => ManageUsers.NameValidaton("", ""));
            Assert.Throws<ArgumentException>(() => ManageUsers.NameValidaton("Sample", ""));
        }

        [Theory]
        [InlineData("Charles ", "  Nazareno  ", "CharlesNazareno")]
        [InlineData(" John", "Wick", "JohnWick")]
        [InlineData(" Micheal", " Jackson   ", "MichealJackson")]
        public void AddingUser_WithCompleteDetails(string firstname, string lastname, string fullname)
        {
            string fullnameResult = ManageUsers.NameValidaton(firstname, lastname);
            Assert.Equal(fullname, fullnameResult);
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
        [Fact]

        public void PasswordValidation_IsInvalid()
        {
            Assert.Throws<ArgumentException>(() => ManageUsers.PasswordValidation("passwordnotvalid"));

        }
    }
}

