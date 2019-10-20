using AutoMapper;
using AutoMapper.QueryableExtensions;
using EventIO.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EventIO.Application.Session.Queries.GetSessionsList
{
    //public class GetSessionsListQuery : IRequest<List<SessionListDto>> {
    //    public class GetSessionsListQueryHandler : IRequestHandler<GetSessionsListQuery, List<SessionListDto>>
    //    {
    //        private readonly IEventDbContext _context;
    //        private readonly IMapper _mapper;

    //        public GetSessionsListQueryHandler(IEventDbContext context, IMapper mapper)
    //        {
    //            _context = context;
    //            _mapper = mapper;
    //        }

    //        public async Task<List<SessionListDto>> Handle(GetSessionsListQuery request, CancellationToken cancellationToken)
    //        {
    //            return await _context.Sessions
    //                .ProjectTo<SessionListDto>(_mapper.ConfigurationProvider)
    //                .ToListAsync(cancellationToken);
    //        }
    //    }
    //}

    public class GetSessionsListQuery : IRequest<List<Domain.Entities.Session>>
    {
        public class GetSessionsListQueryHandler : IRequestHandler<GetSessionsListQuery, List<Domain.Entities.Session>>
        {
            private readonly IEventDbContext _context;
            private readonly IMapper _mapper;

            public GetSessionsListQueryHandler(IEventDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<Domain.Entities.Session>> Handle(GetSessionsList.GetSessionsListQuery request, CancellationToken cancellationToken)
            {
                return await _context.Sessions
                    .Include(s => s.Speaker)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
