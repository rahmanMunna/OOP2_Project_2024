using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Files.Classes
{
    internal class Admin : User
    {
        internal Admin(string userId,string userName,string password) : base(userId,userName,password) 
        {

        }
    }
}
