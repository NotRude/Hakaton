using Microsoft.AspNetCore.Mvc;
using Hakaton.Models;

namespace Hakaton.Controllers
{
    public class EventsController : Controller
    {

        List<Event> events = new List<Event>
        {
            new Event { Id = 1, Address = "Lenina 134", Name = "Футбол", Description = "давай играть в ногомяч"},
            new Event { Id = 2, Address = "Лодыгина 15", Name = "Баскет", Description = "закинимся с тобой?"},
            new Event {Id = 3, Address = "Малышева 30", Name = "Шахматы", Description = "кто кого конем..."},
        };

        public IActionResult Index()
        {
            return View(events);
        }
    }
}
