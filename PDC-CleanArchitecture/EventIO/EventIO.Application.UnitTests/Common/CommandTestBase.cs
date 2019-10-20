using EventIO.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventIO.Application.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        protected readonly EventDbContext _context;

        public CommandTestBase()
        {
            _context = EventDbContextFactory.Create();
        }

        public void Dispose()
        {
            EventDbContextFactory.Destroy(_context);
        }
    }
}
