using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Files.Classes
{
    internal class User
    {
        internal string UserId { get; set; }    
        internal string UserName { get; set; }

        internal string Password { get; set; }

        internal User(string userId,string UserName,string password) 
        {
            this.UserId = userId;
            this.UserName = UserName;   
            this.Password = Password;   
        }

    }
}
