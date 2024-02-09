using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSFullStackApp.Modle;

namespace EMSFullStackApp.Data
{
    public class DeptMasterDbContext : DbContext
    {
        public DeptMasterDbContext (DbContextOptions<DeptMasterDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMSFullStackApp.Modle.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
