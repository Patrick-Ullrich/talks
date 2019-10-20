using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventIO.Application.Session.Commands.SignUpSession;
using EventIO.Application.Session.Queries.GetSessionsList;
using EventIO.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EventIO.Web.Controllers
{
    public class SessionsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<SessionListDto>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetSessionsListQuery()));
        }

        [HttpPost]
        public async Task<ActionResult<int>> SignUpSession([FromBody] SignUpSessionCommand signUpSessionCommand)
        {
            return Ok(await Mediator.Send(signUpSessionCommand));
        }

    }
}