using AutoMapper;
using EventIO.Application.Common.Mappings;
using EventIO.Domain.Entities;

namespace EventIO.Application.Session.Queries.GetSessionsList
{
    public class SessionListDto : IMapFrom<Domain.Entities.Session>
    {
        public int SessionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SignUps { get; set; }
        public Speaker Speaker { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Session, SessionListDto>()
                .ForMember(d => d.SessionId, opt => opt.MapFrom(s => s.SessionId))
                .ForMember(d => d.Title, opt => opt.MapFrom(s => s.Title))
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.Description))
                .ForMember(d => d.SignUps, opt => opt.MapFrom(s => s.SignUps))
                .ForMember(d => d.Speaker, opt => opt.MapFrom(s => new Speaker
                {
                    Name = s.Speaker.Name
                }));
        }
    }
}
