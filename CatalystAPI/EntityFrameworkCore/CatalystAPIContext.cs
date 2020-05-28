using Microsoft.EntityFrameworkCore;
using CatalystAPI.Models;
using System;
using Microsoft.Extensions.Configuration;

namespace CatalystAPI.Data
{
    public class CatalystAPIContext : DbContext
    {
        public CatalystAPIContext(DbContextOptions<CatalystAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }


    }
}
