using System;
using System.Collections.Generic;
using System.Text;

namespace EventIO.Domain.Exceptions
{
    public class BannedSessionTopic : Exception
    {
        public BannedSessionTopic(string title)
            : base($"Session Title \"{title}\" includes a banned Topic.") { }
    }
}
