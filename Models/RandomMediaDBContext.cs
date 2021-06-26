using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomMediaBackend.Models
{
    public class RandomMediaDBContext:DbContext
    {
        public RandomMediaDBContext(DbContextOptions<RandomMediaDBContext> options) : base(options)
        {

        }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
