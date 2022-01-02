using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        //List<User> GetAll();
        //IDataResult<User> GetById(int userId);

        List<OperationClaim> GetClaims(User user);

        User GetByEmail(string email);
    }
}
