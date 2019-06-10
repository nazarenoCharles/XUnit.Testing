using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Linq;

namespace Business
{
    public class ManageUsers : UsersModel
    {
        public List<UsersModel> userlist = new List<UsersModel>();
        public void AddUser(Guid uID, string username, string password, string firstname, string lastname)
        {
            userlist.Add(new UsersModel
            {
                //EntityID = uID;
                FirstName = firstname,
                LastName = lastname,
                PassWord = password,
                UserName = username,
            });
        }
        public static void AddUserToUserlist(List<UsersModel> users, UsersModel userlist)
        {
            if (string.IsNullOrWhiteSpace(userlist.FirstName))
            {
                throw new ArgumentException("You passed in an invalid parameter!", "FirstName");
            }
            if (string.IsNullOrWhiteSpace(userlist.LastName))
            {
                throw new ArgumentException("You passed in an invalid parameter!", "LastName");
            }
            if (string.IsNullOrWhiteSpace(userlist.UserName))
            {
                throw new ArgumentException("You passed in an invalid parameter!", "UserName");
            }
            if (string.IsNullOrWhiteSpace(userlist.PassWord))
            {
                throw new ArgumentException("You passed in an invalid parameter!", "PassWord");
            }
            users.Add(userlist);
        }
    }
}
