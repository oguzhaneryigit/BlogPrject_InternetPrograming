using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<List<Article>> GetAll();
        IDataResult<List<Article>> GetArticlesByUserId(int articleId);
        IDataResult<Article> GetById(int userId);
        IResult AddArticle(Article article);
        IResult DeleteArticle(Article article);
    }
}
