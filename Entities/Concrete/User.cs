﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Rank { get; set; }
        public string? Mail { get; set; }
        public string? TelNo { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Description { get; set; }
        public bool Deleted { get; set; }
        public bool Status { get; set; }

    }
}
