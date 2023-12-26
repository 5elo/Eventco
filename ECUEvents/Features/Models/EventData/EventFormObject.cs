using Application.Common.Mappings;
using ECUEvents.Models.Entities;
using ECUEvents.Models.Lookups;
using Microsoft.EntityFrameworkCore;

namespace ECUEvents.Features.Models.EventData
{
    public class EventFormObject /*: IMapFrom<Event>*/
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;


        public string? Address { get; set; }


        public string? Content { get; set; }
        public string? Brief { get; set; }
        public string? Photo { get; set; }
        public IFormFile? PhotoFile { get; set; }

        public string? Url { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }=DateTime.Now;
        public int? EventCategoryId { get; set; }
        //public DbSet<LkpEventCategory>? EventCategories { get; set; }
        public bool Focus { get; set; }
        public bool Active { get; set; }
    }
}
