using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class UsersModel : BaseClass
    {
        private Guid uID;
        private string firstname;
        private string lastname;
        private string username;
        private string password;

        public string FirstName
        {
            get { return FirstName; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return LastName; }
            set { lastname = value; }
        }
        public string UserName
        {
            get { return UserName; }
            set { username = value; }
        }

        public string PassWord
        {
            get { return PassWord; }
            set { password = value; }
        }

    }
}
