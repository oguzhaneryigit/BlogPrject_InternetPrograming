using Business.Abstract;
using Business.Utilities.Results;
using Business.Utilities.Validators;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Add(User user)
        {
            try
            {
                if (!UserValidator.ValidateUser(user))
                    throw new Exception("eklenen veri uygun değil");

                _userDal.Add(user);
                return new SuccessResult("veri eklendi");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
            
        }

        public IDataResult<List<User>> GetAll()
        {
            try
            {
                //BC
                List<User> _users= _userDal.GetAll();
                return new SuccessDataResult<List<User>>(_users);
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<User>>();
            }
        }

        public IDataResult<User>  GetById(int userId)
        {
            
            try
            {
                //BC
                User _user = _userDal.Get(c => c.UserId == userId);
                return new SuccessDataResult<User>(_user);
            }
            catch (Exception)
            {

                return new ErrorDataResult<User>();
            }
        }

      

        IDataResult<List<OperationClaim>> IUserService.GetClaims(User user)
        {
            try
            {
                var _claims =_userDal.GetClaims(user);
                return new SuccessDataResult<List<OperationClaim>>(_claims);
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<OperationClaim>>();
            }
        }

        IDataResult<User> IUserService.GetByMail(string mail)
        {
            try
            {
                var _user= _userDal.Get(u => u.Mail == mail);
                return new SuccessDataResult<User>(_user);
            }
            catch (Exception)
            {
                return new ErrorDataResult<User>();
            }
        }
    }
}
