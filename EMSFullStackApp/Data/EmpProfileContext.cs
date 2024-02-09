using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSFullStackApp.Modle;

namespace EMSFullStackApp.Data
{
    public class EmpProfileContext : DbContext
    {
        public EmpProfileContext (DbContextOptions<EmpProfileContext> options)
            : base(options)
        {
        }

        public DbSet<EMSFullStackApp.Modle.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
