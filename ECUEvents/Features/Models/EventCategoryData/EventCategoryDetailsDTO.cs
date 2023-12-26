using Application.Common.Mappings;
using Domain.Enums;
using ECUEvents.Models.Lookups;
using System.ComponentModel.DataAnnotations;

namespace ECUEvents.Features.Models
{
    public class EventCategoryDetailsDTO:IMapFrom<LkpEventCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
