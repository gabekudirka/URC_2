using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using URC_2.Models;

namespace URC_2.Data
{
    public class URCContext : DbContext
    {
        public URCContext (DbContextOptions<URCContext> options)
            : base(options)
        {
        }

        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Opportunity>().ToTable("Opportunity");
            modelBuilder.Entity<Tag>().ToTable("Tag");
            modelBuilder.Entity<Skill>().ToTable("Skill");
        }
    }
}
