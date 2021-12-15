using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    class EfLikeDal : ILikeDal
    {
        public void Add(Like entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Like entity)
        {
            throw new NotImplementedException();
        }

        public Like Get(Expression<Func<Like, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Like> GetAll(Expression<Func<Like, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Like entity)
        {
            throw new NotImplementedException();
        }
    }
}
