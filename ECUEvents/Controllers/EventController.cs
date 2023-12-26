using AutoMapper.QueryableExtensions;
using ECUEvents.Data;
using ECUEvents.Features.Commands.EventCommand;
using ECUEvents.Features.Models;
using ECUEvents.Features.Models.EventData;
using ECUEvents.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ECUEvents.Controllers
{
    public class EventController : Controller
    {
        #region CTOR
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;
        public EventController(ApplicationDbContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion

        [HttpPost]
        public IActionResult Search(string SearchKeyword)
        {
            IEnumerable<EventDTO> EventList=_context.Events.
                Where(x=>x.Title.ToLower().Contains(SearchKeyword.ToLower()) || x.EventCategory.Name.ToLower().Contains(SearchKeyword.ToLower())).Select(x => new EventDTO
                {
                    Id = x.Id,
                    Title = x.Title,
                    EventCategoryName = x.EventCategory.Name,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Active = x.Active,
                    CreateDate = x.CreateDate,
                }).OrderByDescending(x => x.CreateDate).ToList(); ;
           return View("Index", EventList);
        }

        #region Index

        
        public IActionResult Index()
        {
            IEnumerable<EventDTO> EventList = _context.Events/*.Where(x=>x.Active==true)*/.Select(x => new EventDTO
            {
                Id = x.Id,
                Title = x.Title,
                EventCategoryName = x.EventCategory.Name,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Active = x.Active,
                CreateDate = x.CreateDate,
            }).OrderByDescending(x => x.CreateDate).ToList();
            return View(EventList);
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            var entity = _context.Events.Include(x=>x.EventCategory).Where(x => x.Id == id).FirstOrDefault();


            EventDetailsDTO eventdetailsdto=new EventDetailsDTO
            {
                Id=entity.Id,
                Title=entity.Title,
                Address = entity.Address,
                Brief = entity.Brief,
                Content = entity.Content,
                Photo = entity.Photo,
                EndDate=entity.EndDate,
                StartDate=entity.StartDate,
                EventCategoryName=entity.EventCategory.Name,
                Url = entity.Url,
            };

            return View(eventdetailsdto);
        }
        #endregion

        #region Create

        public IActionResult Create()
        {
            var eventcategory = _context.EventCategories.ToList();
            ViewBag.EventCategory = new SelectList(eventcategory, "Id", "Name");

            return PartialView("Form", new EventFormObject());
        }
        
      
        [HttpPost]
        [ValidateAntiForgeryToken]
  
        public IActionResult Create(EventFormObject request, IFormFile PhotoFile)
        {
            try
            {
                request.PhotoFile = PhotoFile;
                CreateEventCommand command = new CreateEventCommand(request);
                var CreatedEvent = command.AddEvent(request);
                _context.Events?.Add(CreatedEvent);
                _context.SaveChanges();
                //if (request.PhotoFile.FileName != null && request.PhotoFile.Length > 0)
                //{
                //    var fileName = Path.GetFileName(request.PhotoFile.FileName);
                //    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Upload", "Event");

                //    if (!Directory.Exists(filePath))
                //    {
                //        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                //    }


                //    using (var stream = new FileStream(filePath, FileMode.Create))
                //    {
                //        request.PhotoFile.CopyTo(stream);
                //    }
                //}


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Edit
       
        public IActionResult Edit(int id)
        {
            var eventcategory = _context.EventCategories.ToList();
            ViewBag.EventCategory = new SelectList(eventcategory, "Id", "Name");

            Event entity = _context.Events.Where(x => x.Id == id).FirstOrDefault();

            EventFormObject command = new EventFormObject()
            {
                Id = entity.Id,
                Title = entity.Title,
                Address = entity.Address,
                Brief = entity.Brief,
                Url = entity.Url,
                EventCategoryId = entity.EventCategoryId,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Active = entity.Active,
                Focus = entity.Focus
            };

            return PartialView("Form", command);
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventFormObject request, int id, IFormCollection collection)
        {
            try
            {
                UpdateEventCommand command = new UpdateEventCommand(request, _context);
                var UpdateEvent = command.EditEvent(request);
                _context.Events.Update(UpdateEvent);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {

            var entity = _context.Events.Where(x => x.Id == id).FirstOrDefault();
            if(entity!=null)
            {
                _context.Events.Remove(entity);
                _context.SaveChanges();
            }

            return  RedirectToAction(nameof(Index));
        }
        #endregion

    }
}
