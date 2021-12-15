using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class Article
    {
        public int ArticleId { get; set; }
        public int AuthorId { get; set; }
        public DateTime ReleaseTime { get; set; }
        public string Heading { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }

    }
}
