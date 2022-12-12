using CQRS_İstanbulEğitimAkademi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEğitimAkademi.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YUNUS\\SQLEXPRESS;initial catalog=ZCQRSDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
