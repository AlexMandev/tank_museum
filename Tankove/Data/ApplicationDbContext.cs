using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tankove.Models;

namespace Tankove.Data
{
    public class ApplicationDbContext: DbContext
    {
        //database options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Tanks> Tanks { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
