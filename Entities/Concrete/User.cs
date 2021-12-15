using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Mail { get; set; }
        public string TelNo { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    }
}
