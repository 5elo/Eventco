
using ECUEvents.Enums;
using ECUEvents.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ECUEvents.Models.Lookups
{
    public class LkpEventCategory:LookupBase
    {
        public ICollection<Event>? Events { get; set; }
    }
}
