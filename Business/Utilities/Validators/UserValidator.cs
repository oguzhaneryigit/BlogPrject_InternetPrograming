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
            if (user.Rank.Length > 10)
                return false;
            if (user.Mail.Length > 30)
                return false;
            if (user.TelNo.Length > 15)
                return false;
            if (user.Description.Length > 10)//null veri sıkıntı yaratıyor
                return false;


            return true;
        }
    }
}
