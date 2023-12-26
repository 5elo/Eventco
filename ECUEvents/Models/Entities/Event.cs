using ECUEvents.Common;
using ECUEvents.Models.Lookups;

namespace ECUEvents.Models.Entities
{
    public class Event : ObjectBass
    {
        public string Title { get; set; } = String.Empty;


        public string? Address { get; set; }


        public string? Content { get; set; }
        public string? Brief { get; set; }
        public string? Photo { get; set; }
        public int? price { get; set; } 

        public string? Url { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? EventCategoryId { get; set; }
        public virtual LkpEventCategory? EventCategory { get; set; }


    }
}