using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EventIO.Application.Session.Queries.GetSessionsList
{
    public class GetSessionsListQueryHandler : IRequestHandler<GetSessionsListQuery, List<Domain.Entities.Session>>
    {


        public async Task<List<Domain.Entities.Session>> Handle(GetSessionsListQuery request, CancellationToken cancellationToken)
        {
            return new List<Domain.Entities.Session>
            {
                new Domain.Entities.Session()
                {
                    SessionId = 1,
                    Title = "Angular State Management: Beyond NGRX",
                    Description = "NGRX is a large opinionated library on how to do state management in Angular and is often marketed as ‘The Solution’ to all your state management woes. This talk is to tell you that NGRX isn’t the panacea to every ailment. On top of not curing my baldness NGRX is not always how to solve state management. There’s lots of other ways to deal with state management in Angular. This talk walks through the life of an Angular app and the appropriate state management tactics at different milestones. One size does not fit all. Of course, an internet bucket of hype has to be based on something, so we’ll finish with ‘when you need NGRX how to get started.",
                    SignUps = 0,
                    SpeakerId = 1
                }
            };
        }
    }
}
