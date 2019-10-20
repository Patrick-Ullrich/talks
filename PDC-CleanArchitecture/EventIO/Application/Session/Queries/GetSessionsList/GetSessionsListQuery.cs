using MediatR;
using System.Collections.Generic;
using EventIO.Domain.Entities;

namespace EventIO.Application.Session.Queries.GetSessionsList
{
    public class GetSessionsListQuery : IRequest<List<Domain.Entities.Session>>
    {
    }
}
