using CopiaFacebook.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Infrastructure.Persistence
{
    public class CopiaFacebookDbContext:DbContext
    {
        public CopiaFacebookDbContext(DbContextOptions<CopiaFacebookDbContext> options) : base(options) { }

        public DbSet<User> Users { get; private set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
