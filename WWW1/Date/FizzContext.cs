using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWW1.Models;

namespace WWW1.Date
{
    public class FizzContext: DbContext
    {
        public DbSet<Czas> Czas { get; set; }

        public FizzContext(DbContextOptions options) : base(options) { }
    }
}
