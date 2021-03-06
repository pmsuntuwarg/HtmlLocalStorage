﻿using System;
using System.Collections.Generic;
using System.Text;
using LocalStorage.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocalStorage.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
        public DbSet<TestFormModel> TestForm { get; set; }
        public DbSet<UserMasterModel> UserMaster { get; set; }
        public DbSet<UserPhoneDetailModel> UserPhoneDetail { get; set; }

    }
}
