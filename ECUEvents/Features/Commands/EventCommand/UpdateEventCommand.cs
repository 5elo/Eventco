using ECUEvents.Data;
using ECUEvents.Features.Models.EventData;
using ECUEvents.Models.Entities;

namespace ECUEvents.Features.Commands.EventCommand
{
    public class UpdateEventCommand : EventFormObject
    {
        private readonly ApplicationDbContext _context;
        public UpdateEventCommand()
        {
        }
        public UpdateEventCommand(EventFormObject dto,ApplicationDbContext context)
        {
            Id = dto.Id;
            Title = dto.Title;
            Address = dto.Address;
            Content = dto.Content;
            Brief = dto.Brief;
            Photo = dto.Photo;
            Url = dto.Url;
            StartDate = dto.StartDate;
            EndDate = dto.EndDate;
            EventCategoryId = dto.EventCategoryId;
            Focus = dto.Focus;
            Active = dto.Active;
            _context = context;

        }



        public Event EditEvent(EventFormObject request)
        {
            Event entity = _context.Events.FirstOrDefault(e => e.Id == request.Id);
            entity.Id = request.Id;
            entity.Title = request.Title;
            entity.Address = request?.Address;
            entity.Content = request?.Content;
            entity.Brief = request?.Brief;
            entity.Url = request?.Url;
            entity.EventCategoryId = 1; /*request.EventCategoryId;*/
            entity.StartDate = request.StartDate;
            entity.EndDate = request.EndDate;
            entity.Focus = request.Focus;
            entity.Active = request.Active;
            entity.ModifyDate=DateTime.Now;
            entity.CreateDate = DateTime.Now;
            return entity;
        }

    }
}
