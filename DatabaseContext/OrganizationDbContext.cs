﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Models;
//using OnlineExamSystem.Models;


namespace DatabaseContext
{
    public class OrganizationDbContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Course> Courses { get; set; }

       
    }
}
