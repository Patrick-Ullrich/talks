using EventIO.Application.Common.Interfaces;
using EventIO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EventIO.Persistence
{
    public class EventDbContext : DbContext, IEventDbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options) { }

        public DbSet<Speaker> Speakers { get; set; } 
        public DbSet<Session> Sessions { get; set; }
    }
}
