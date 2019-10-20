using EventIO.Domain.Entities;
using EventIO.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventIO.Application.UnitTests.Common
{

    public class EventDbContextFactory
    {
        public static EventDbContext Create()
        {
            var options = new DbContextOptionsBuilder<EventDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new EventDbContext(options);
            context.Speakers.AddRange(
                                   new Speaker()
                                   {
                                       SpeakerId = 1,
                                       Name = "Alexander Wiebe",
                                       Secret = "Loves Angular"
                                   },
                                   new Speaker()
                                   {
                                       SpeakerId = 2,
                                       Name = "David Crossman",
                                       Secret = "Loves Git"
                                   },
                                   new Speaker()
                                   {
                                       SpeakerId = 3,
                                       Name = "Patrick Ullrich",
                                       Secret = "Loves .NET Core"
                                   }
                           );

            context.Sessions.AddRange(
                new Domain.Entities.Session()
                {
                    SessionId = 1,
                    Title = "Angular State Management: Beyond NGRX",
                    Description = "NGRX is a large opinionated library on how to do state management in Angular and is often marketed as ‘The Solution’ to all your state management woes. This talk is to tell you that NGRX isn’t the panacea to every ailment. On top of not curing my baldness NGRX is not always how to solve state management. There’s lots of other ways to deal with state management in Angular. This talk walks through the life of an Angular app and the appropriate state management tactics at different milestones. One size does not fit all. Of course, an internet bucket of hype has to be based on something, so we’ll finish with ‘when you need NGRX how to get started.",
                    SignUps = 0,
                    SpeakerId = 1
                },
                new Domain.Entities.Session()
                {
                    SessionId = 2,
                    Title = "Demystifying Git - Git Under the Hood",
                    Description = "When working within a project using Git, you notice a folder .git with a bunch of files and folders containing all types of information. The technical talk will cover some plumbing and porcelain commands with Git and how it manages your files within the .git folder. We will do a deep dive into how Git store data and how it all comes together to track changes for files and folders.",
                    SignUps = 0,
                    SpeakerId = 2
                },
                new Domain.Entities.Session()
                {
                    SessionId = 3,
                    Title = "Vertical Slice Architecture with .Net Core and MediatR - A Work in Progress",
                    Description = "A good architecture should reduce business risk associated to the solution. This is a hard task, especially if requirements can change constantly. Inspired by Jimmy Bogards talk on Vertical Slice Architecture, we will build out a foundation for a project using Dot Net Core 2.2 and MediatR and walk through some real life scenarios to see if the architecture can adapt to any new requirements we are introducing.",
                    SignUps = 0,
                    SpeakerId = 3
                }
            );

            context.SaveChanges();

            return context;
        }

        public static void Destroy(EventDbContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
