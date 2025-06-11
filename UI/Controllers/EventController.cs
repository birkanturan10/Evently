using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class EventController : Controller
    {
        private readonly EventManager _eventManager;

        public EventController(Context context)
        {
            _eventManager = new EventManager(new GenericRepository<Event>(context));
        }

        public IActionResult Index()
        {
            var values = _eventManager.GetList();
            return View(values);
        }
    }
}
