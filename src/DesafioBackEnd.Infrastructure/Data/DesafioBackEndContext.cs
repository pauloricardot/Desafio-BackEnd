using DesafioBackEnd.Domain.Entities;
using DesafioBackEnd.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackEnd.Infrastructure.Data
{
    public class DesafioBackEndContext : DbContext
    {
        public DesafioBackEndContext(DbContextOptions<DesafioBackEndContext> options)
            : base(options)
        {

        }
        public DbSet<PeopleEntity> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PeopleEntity>(new PeopleMap().Configure);
        }
    }
}
