using Business.Abstract;
using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class LikeManager : ILikeService
    {
        public IDataResult<List<Like>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Like> GetById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
