using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Business
{
    public class ManageUsers : UsersModel
    {
        readonly List<UsersModel> userlist = new List<UsersModel>();
        
        //public void EditUser(string firstname, string lastname)
        //{
        //    userlist.Where(x => x.UserName == UserName);
        //    foreach(var user in userlist)
        //    {
        //       // userlist.Where(x => x.UserName == "Blast")
        //       //.Select(x => { x.UserName = username; return x; }).ToList();
        //       // userlist.Where(x => x.PassWord == "samplepasswordagain")
        //       //.Select(x => { x.PassWord = password; return x; }).ToList();
        //        userlist.Where(x => x.FirstName == "Charles")
        //       .Select(x => { x.FirstName = firstname; return x; }).ToList();
        //        userlist.Where(x => x.LastName == "Nazareno")
        //       .Select(x => { x.LastName = lastname; return x; }).ToList();
        //    }

        //}
        public ManageUsers AddingUser(string username, string password, string firstname, string lastname)
        {
            ManageUsers person = new ManageUsers()
            {
                UserName = "blast42",
                PassWord = "pass",
                FirstName = "charles",
                LastName = "nazareno",
            };
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                throw new ArgumentException("Invalid First name!", "FirstName");
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                throw new ArgumentException("Invalid Last Name!", "LastName");
            }
            if (string.IsNullOrWhiteSpace(person.UserName))
            {
                throw new ArgumentException("Invalid Username!", "UserName");
            }
            if (string.IsNullOrWhiteSpace(person.PassWord))
            {
                throw new ArgumentException("Invalid Password!", "PassWord");
            }
           
            return person;

        }
        public static string NameValidaton( string firstname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException("First name must be provided.");
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentException("Last name must be provided.");
            }
            return $"{firstname.Trim()}{lastname.Trim()}".Trim();
        }

        public static bool PasswordValidation(string password)
        {
            var input = password;
           
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                throw new ArgumentException("Password should contain atleast one lower case character!");
                
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                throw new ArgumentException("Password should contain atleast one upper case character!");
              
            }
            else if (!hasNumber.IsMatch(input))
            {
                throw new ArgumentException("Password should contain a number!");
              
            }
            else
            {
                return true;
            }
        }
        public void UserDeletion(string username)
        {
            userlist.RemoveAll(x => x.UserName == username);
        }
        //public static void AddUserToTheList(List<UsersModel> user, UsersModel person)
        //{
            
        //}
        //public void UserShouldEdit()
        //{

        //}
    }

}
