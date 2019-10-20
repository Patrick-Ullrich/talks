using System;
using AutoMapper;
using EventIO.Application.Common.Mappings;
using EventIO.Persistence;
using Xunit;

namespace EventIO.Application.UnitTests.Common
{
    public class QueryTestFixture : IDisposable
    {
        public EventDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            Context = EventDbContextFactory.Create();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = configurationProvider.CreateMapper();
        }

        public void Dispose()
        {
            EventDbContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}
