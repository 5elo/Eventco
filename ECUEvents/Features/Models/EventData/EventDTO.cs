using Application.Common.Mappings;
using AutoMapper;
using ECUEvents.Models.Entities;

namespace ECUEvents.Features.Models
{
    public class EventDTO /*: IMapFrom<Event>*/
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string EventCategoryName { get; set; }
        public bool Active { get; set; }
        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<Event, EventDTO>()
        //        .ForMember(x => x.EventCategoryName, opt => opt.MapFrom(x => x.EventCategory.Name));
        //}
    }
}
