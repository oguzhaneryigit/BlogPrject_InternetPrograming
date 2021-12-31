using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILikeService
    {
        IDataResult<List<Like>> GetAll();
        IDataResult<Like> GetById(int userId);
    }
}
