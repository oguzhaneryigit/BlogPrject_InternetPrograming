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

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        [SecuredOperation("admin,user")]
        public IResult AddArticle(Article article)
        {
            _articleDal.Add(article);
            return new SuccessResult("Metin Eklendi.");

        }

        
        public IResult DeleteArticle(Article article)
        {
            Article articleToUpdate = _articleDal.Get(x=> x.ArticleId==article.ArticleId && x.AuthorId==article.AuthorId);
            if (articleToUpdate==null)
            {
                return new ErrorResult("gönderi bulunamadı");
            }
            articleToUpdate.Deleted = true;
            _articleDal.Update(articleToUpdate);
            return new SuccessResult("gönderi silindi");
        }

        //[SecuredOperation("admin")]
        public IDataResult<List<Article>> GetAll()
        {
            List<Article> articles = _articleDal.GetAll();
            return new SuccessDataResult<List<Article>>(articles);    
        }

        public IDataResult<List<Article>> GetArticlesByUserId(int userId)
        {
            List<Article> articles = _articleDal.GetAll(x => x.AuthorId == userId && x.Deleted==false);
            return new SuccessDataResult<List<Article>>(articles);
        }

        public IDataResult<Article> GetById(int articleId)
        {
            Article article = _articleDal.Get(x => x.ArticleId == articleId);
            return new SuccessDataResult<Article>(article);
        }
    }
}
