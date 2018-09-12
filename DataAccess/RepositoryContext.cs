using System;
using Microsoft.EntityFrameworkCore;
using tour_logistic.Models;

namespace tour_logistic.DataAccess
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options) { }

        public DbSet<User> Users;
        public DbSet<Route> Routes;

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<User>().Property(u => u.Login).IsRequired();
            builder.Entity<User>().Property(u => u.Password).IsRequired();            
        }
    }
}