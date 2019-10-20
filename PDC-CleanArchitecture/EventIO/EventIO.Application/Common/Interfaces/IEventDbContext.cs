using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EventIO.Application.Common.Interfaces
{
    public interface IEventDbContext
    {
        public DbSet<Domain.Entities.Speaker> Speakers { get; set; }
        public DbSet<Domain.Entities.Session> Sessions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
