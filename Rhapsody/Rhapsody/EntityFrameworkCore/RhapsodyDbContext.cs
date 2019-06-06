using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rhapsody
{
    public abstract class RhapsodyDbContext<TSelf> : RhapsodyCommonDbContext <TSelf>
        where TSelf : RhapsodyDbContext< TSelf> 
    {
        //protected RhapsodyDbContext(DbContextOptions<TSelf> options);

        //protected override void OnModelCreating(ModelBuilder modelBuilder);
    }

    public abstract class RhapsodyDbContext : DbContext
    {
        public RhapsodyDbContext(
            DbContextOptions<RhapsodyDbContext> options
            ) : base(options)
    	{ }
    }
}
