using EventIO.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventIO.Domain.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public int SpeakerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SignUps { get; set; }
        public Speaker Speaker { get; set; }
    }
}
