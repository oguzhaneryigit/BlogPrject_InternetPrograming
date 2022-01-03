using Business.Abstract;
using Business.BusinessAspectsAutofac;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal categoryDal)
        {
            _articleDal = categoryDal;
        }
        
        [SecuredOperation("admin")]
        public IDataResult<List<Article>> GetAll()
        {
            
            List<Article> articles = _articleDal.GetAll();
            return new SuccessDataResult<List<Article>>(articles);
            
            //return new ErrorDataResult<List<Article>>();
                      
        }

        public IDataResult<List<Article>> GetArticlesByUserId(int userId)
        {
            List<Article> articles = _articleDal.GetAll(x => x.AuthorId == userId);
            return new SuccessDataResult<List<Article>>(articles);
        }

        public IDataResult<Article> GetById(int articleId)
        {
            Article article = _articleDal.Get(x => x.ArticleId == articleId);
            return new SuccessDataResult<Article>(article);
        }
    }
}
