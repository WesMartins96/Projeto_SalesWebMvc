﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_SalesWebMvc.Models;

namespace Projeto_SalesWebMvc.Data
{
    public class Projeto_SalesWebMvcContext : DbContext
    {
        public Projeto_SalesWebMvcContext (DbContextOptions<Projeto_SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        
    }
}
