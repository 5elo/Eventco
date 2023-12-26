using Application.Common.Mappings;
using ECUEvents.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECUEvents.Features.Models.EventCategory
{
    public class EventCategoryDTO:IMapFrom<LkpEventCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime CreateDate { get; set; }
        public bool Focus { get; set; }
        public bool Active { get; set; }
    }
}
