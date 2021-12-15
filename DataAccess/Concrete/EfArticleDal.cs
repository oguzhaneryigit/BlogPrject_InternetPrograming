using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    class EfArticleDal : IArticleDal
    {
        public void Add(Article entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Article entity)
        {
            throw new NotImplementedException();
        }

        public Article Get(Expression<Func<Article, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAll(Expression<Func<Article, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
