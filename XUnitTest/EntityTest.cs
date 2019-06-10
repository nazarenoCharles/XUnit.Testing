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
        [Theory]
        [InlineData("blazt42", "Charles", "Nazareno", "passsample123")]
        public void User_ShouldAddUser(string username, string firstname, string lastname, string password)
        {
            UsersModel newUser = new UsersModel { UserName = username, FirstName = firstname, LastName = lastname, PassWord = password};
            List<UsersModel> user = new List<UsersModel>();

            ManageUsers.AddUserToUserlist(user, newUser);
            user.Add(newUser);

            int expected = 1;
            int actual = user.Count;

            Assert.Equal(expected, actual);
        }
    }
}
