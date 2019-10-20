using EventIO.Application.UnitTests.Common;
using MediatR;
using Moq;
using AutoMapper;
using Xunit;
using EventIO.Application.Session.Queries.GetSessionsList;
using System.Threading;
using System.Threading.Tasks;
using Shouldly;
using System.Collections.Generic;
using EventIO.Persistence;

namespace EventIO.Application.UnitTests.Session.Queries.GetSessionList
{
    [Collection("QueryCollection")]
    public class GetSessionListQueryTest : CommandTestBase
    {

        private readonly IMapper _mapper;
        private readonly EventDbContext _context;

        public GetSessionListQueryTest(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetSessionListTest()
        {
            // Arrange
            var query = new GetSessionsListQuery.GetSessionsListQueryHandler(_context, _mapper);

            // Act
            var result = await query.Handle(new GetSessionsListQuery(), CancellationToken.None);

            // Assert
            result.ShouldBeOfType<List<Domain.Entities.Session>>();
            result.Count.ShouldBe(3);
        }
    }
}
