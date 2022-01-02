using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Utilities.Validators
{
    public class UserValidator
    {
        public static bool ValidateUser(User user)
        {
            if (user.Name.Length>10)
                return false;
            if (user.Email.Length > 30)
                return false;



            return true;
        }
    }
}
