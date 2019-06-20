using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cwic10.Models
{
    public class cwic10Context : DbContext
    {
        public cwic10Context (DbContextOptions<cwic10Context> options)
            : base(options)
        {
        }

        public DbSet<cwic10.Models.Student> Student { get; set; }
    }
}
