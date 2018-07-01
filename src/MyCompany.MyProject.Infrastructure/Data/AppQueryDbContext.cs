﻿using System;
using System.Collections.Generic;
using System.Text;
using MyCompany.MyProject.ApplicationCore.SharedKernel;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.MyProject.Infrastructure.Data
{
    public class AppQueryDbContext : AppDbContext
    {
        readonly IDbConnectionFactory _dbConnectionFactory;

        public AppQueryDbContext(IDbConnectionFactory dbConnectionFactory, ISystemDateTime systemDateTime) : base(dbConnectionFactory, systemDateTime)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnectionFactory.DefaultQuery());
        }
    }
}