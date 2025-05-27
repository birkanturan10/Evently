using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EventManager : IEventService
    {
        private readonly IGenericRepository<Event> _eventRepository;

        public EventManager(IGenericRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void AddEvent(Event e)
        {
            _eventRepository.Insert(e);
        }

        public void DeleteEvent(Event e)
        {
            _eventRepository.Delete(e);
        }

        public void UpdateEvent(Event e)
        {
            _eventRepository.Update(e);
        }

        public Event GetById(int id)
        {
            return _eventRepository.GetById(id);
        }

        public List<Event> GetList()
        {
            return _eventRepository.GetList();
        }
    }
}
