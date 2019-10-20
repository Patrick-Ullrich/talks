using EventIO.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventIO.Application.Session.Commands.SignUpSession
{
    public class SignUpSessionCommand : IRequest<int>
    {
        public int SessionId { get; set; }

        public class SignUpSessionCommandHandler : IRequestHandler<SignUpSessionCommand, int>
        {
            private readonly IEventDbContext _context;

            public SignUpSessionCommandHandler(IEventDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(SignUpSessionCommand request, CancellationToken cancellationToken)
            {
                var session = await _context.Sessions.Where(x => x.SessionId == request.SessionId).SingleOrDefaultAsync(cancellationToken);

                if (session == null)
                {
                    return 0;
                }

                session.SignUps++;

                await _context.SaveChangesAsync(cancellationToken);

                return session.SignUps;
            }
        }
    }
}
