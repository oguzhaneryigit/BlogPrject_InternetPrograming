using Business.Abstract;
using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        public IDataResult<List<Article>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Article> GetById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
