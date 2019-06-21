using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test2.Models
{
    public class Test2Context : DbContext
    {
        public Test2Context (DbContextOptions<Test2Context> options)
            : base(options)
        {
        }

        public DbSet<Test2.Models.Movies> Movies { get; set; }
    }
}
