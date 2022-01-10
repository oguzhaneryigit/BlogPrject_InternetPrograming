using Business.Abstract;
using Business.BusinessAspectsAutofac;
using Business.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpPost("addarticle")]
        public IActionResult AddArticle(Article article)
        {
            try
            {
                var result = _articleService.AddArticle(article);
                if (!result.Success)
                {
                    throw new Exception(result.Message+" Article Eklenemedi");
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new ErrorResult(e.Message));
            }
        }

        [HttpPost("deletearticle")]
        public IActionResult DeleteArticle(Article article)
        {
            try
            {
                var result = _articleService.DeleteArticle(article);
                if (!result.Success)
                {
                    throw new Exception(result.Message);
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new ErrorResult(e.Message));
            }
        }

        [HttpGet("getallarticles")]
        public ActionResult GetAll( )
        {
            try
            {
                var result = _articleService.GetAll();
                if (!result.Success)
                {
                    throw new Exception(result.Message);
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new ErrorResult(e.Message));
            }
        }

        [HttpGet("getarticlesbyid")]
        public ActionResult GetArticlesByUserId(int id)
        {
            try
            {
                var result = _articleService.GetArticlesByUserId(id);
                if (!result.Success)
                {
                    throw new Exception(result.Message);
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new ErrorResult(e.Message));
            }
        }
    }
}
