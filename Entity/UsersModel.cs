using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class UsersModel : BaseClass
    {
        Guid uID;
        private string firstname;
        private string lastname;
        private string username;
        private string password;

        public Guid EntityID
        {
            get { return this.uID; }
            set { uID = value; }
        }
        public string FirstName
        {
            get { return this.firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { lastname = value; }
        }
        public string UserName
        {
            get { return this.username; }
            set { username = value; }
        }

        public string PassWord
        {
            get { return this.password; }
            set { password = value; }
        }

    }
}
