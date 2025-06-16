using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Event e)
        {
            _eventManager.AddEvent(e);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var eventToDelete = _eventManager.GetById(id);
            return View(eventToDelete);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var eventToDelete = _eventManager.GetById(id);
            _eventManager.DeleteEvent(eventToDelete);
            return RedirectToAction("Index");
        }
    }
}
