﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class BlogProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-J93QKI0;Database=BlogProject;Trusted_Connection=true;");

           
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Like> Likes{ get; set; }

    }
}
