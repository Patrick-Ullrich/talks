using EventIO.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventIO.Domain.Entities
{
    public class Session
    {
        public static Session For(string title, string description, int speakerId)
        {
            var session = new Session();

            if(title.ToLower().IndexOf("java") != -1)
            {
                throw new BannedSessionTopic(title);
            }

            session.Title = title;
            session.Description = description;
            session.SpeakerId = speakerId;

            return session;
        }
        public int SessionId { get; set; }
        public int SpeakerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SignUps { get; set; }
        public Speaker Speaker { get; set; }
    }
}
