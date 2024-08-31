using Compny.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compny.Data.Contexts
{
    public class CompnyDBcontext : DbContext
    {
        public CompnyDBcontext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}

        public DbSet<Emp> Emps { get; init; }
        public DbSet<Dept> Depts { get; init; }
    }
}
