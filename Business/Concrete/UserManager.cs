using Business.Abstract;
using Business.BusinessAspectsAutofac;
using Business.Utilities.CrossCuttingConcerns.Validation;
using Business.Utilities.Results;
using Business.Utilities.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        //[SecuredOperation("product.add,admin")]
        public void Add(User user)
        {

            ValidationTool.Validate(new UserValidator(), user);

            _userDal.Add(user);
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
