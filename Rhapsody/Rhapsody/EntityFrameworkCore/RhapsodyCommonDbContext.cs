using Microsoft.EntityFrameworkCore;
using Rhapsody.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rhapsody
{
    public abstract class RhapsodyCommonDbContext<TSelf> : RhapsodyCoreDbContext where TSelf : RhapsodyCommonDbContext<TSelf>
    {
        //protected RhapsodyCommonDbContext(DbContextOptions<TSelf> options);

        //public virtual DbSet<AuditLog> AuditLogs { get; set; }

        //public override int SaveChanges();
        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        //protected override void OnModelCreating(ModelBuilder modelBuilder);
    }
}
