using EventIO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventIO.Persistence.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(e => e.SessionId).HasColumnName("SessionID");

            builder.Property(e => e.Title).HasMaxLength(1000);
        }
    }
}
