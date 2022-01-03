using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Article:IEntity
    {
        public int ArticleId { get; set; }
        public int AuthorId { get; set; }
        public string Heading { get; set; }
        public int CategoryId { get; set; }
        public string Text { get; set; }
        public bool Deleted { get; set; }
    }
}
