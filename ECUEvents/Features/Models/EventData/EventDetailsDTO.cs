using Application.Common.Mappings;
using AutoMapper;
using ECUEvents.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECUEvents.Features.Models
{
    public class EventDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;

        public string? Address { get; set; }
        public string? Content { get; set; }
        public string? Brief { get; set; }
        public string? Photo { get; set; }
        public string? Url { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string EventCategoryName { get; set; }

    }
}
