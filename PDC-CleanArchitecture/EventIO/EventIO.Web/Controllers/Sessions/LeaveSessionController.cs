using EventIO.Application.Common.Interfaces;
using EventIO.Application.Session.Commands.SignUpSession;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventIO.Web.Controllers.Sessions
{
    public class SessionsController : BaseController
    {
        [HttpPost]
        public async Task<ActionResult<int>> LeaveSession([FromBody] LeaveSessionCommand leaveSessionCommand)
        {
            return Ok(await Mediator.Send(leaveSessionCommand));
        }
    }
    public class LeaveSessionCommand : IRequest<int>
    {
        public int SessionId { get; set; }
    }

    public class LeaveSessionCommandHandler : IRequestHandler<LeaveSessionCommand, int>
    {
        private readonly IEventDbContext _context;

        public LeaveSessionCommandHandler(IEventDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(LeaveSessionCommand request, CancellationToken cancellationToken)
        {
            var session = await _context.Sessions.Where(x => x.SessionId == request.SessionId).SingleOrDefaultAsync(cancellationToken);

            if (session == null)
            {
                return 0;
            }

            session.SignUps--;

            await _context.SaveChangesAsync(cancellationToken);

            return session.SignUps;
        }
    }


}
