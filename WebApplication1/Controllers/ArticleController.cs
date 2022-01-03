using Business.Abstract;
using Business.BusinessAspectsAutofac;
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

        [HttpGet("getallarticles")]
        public ActionResult GetAll( )
        {
            //try
            //{
            //    var result = _articleService.GetAll();
            //    if (result.Success!)
            //    {
            //        throw new Exception(result.Message);
            //    }
            //    return Ok(result.Data);
            //}
            //catch (Exception e)
            //{
            //    return BadRequest(e.Message);
            //}
            var result = _articleService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
