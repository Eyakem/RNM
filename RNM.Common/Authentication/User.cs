using RNM.Common.Constants;
using RNM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.Common.Authentication
{
    public class User: IUser
    {
        private UserType type;
        public User(UserType type)
        {
            this.type = type;
            
        }
    }
}
