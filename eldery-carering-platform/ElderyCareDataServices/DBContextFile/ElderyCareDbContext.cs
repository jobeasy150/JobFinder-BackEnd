using ElderyCareDataServices.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElderyCareDataServices.DBContextFile
{
    public class ElderyCareDbContext : DbContext
    {
        public ElderyCareDbContext(DbContextOptions<ElderyCareDbContext> options):base(options) 
        { }
        public DbSet<Test> test { get; set; }
    }
}
