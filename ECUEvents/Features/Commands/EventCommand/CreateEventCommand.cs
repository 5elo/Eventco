using ECUEvents.Features.Models.EventData;
using ECUEvents.Models.Entities;
using System.ComponentModel;

namespace ECUEvents.Features.Commands.EventCommand
{
    public class CreateEventCommand : EventFormObject
    {
        
        public CreateEventCommand()
        {
        }
        public CreateEventCommand(EventFormObject dto)
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

        }



        public Event AddEvent(EventFormObject request)
        {
            Event entity = new Event();
            entity.Id = request.Id;
            entity.Title = request.Title;
            entity.Address = request.Address;
            entity.Content = request.Content;
            entity.Brief = request.Brief;
            entity.Url = request.Url;
            entity.EventCategoryId = request.EventCategoryId;
            entity.StartDate = request.StartDate;
            entity.EndDate = request.EndDate;

            entity.Photo = request.PhotoFile?.FileName;
            entity.Focus = request.Focus;
            entity.Active = request.Active;
            entity.CreateDate=DateTime.Now;


           
            return entity;
        }

    }
}
