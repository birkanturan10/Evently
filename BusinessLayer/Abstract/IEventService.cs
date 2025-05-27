using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEventService
    {
        void AddEvent(Event e);
        void DeleteEvent(Event e);
        void UpdateEvent(Event e);
        Event GetById(int id);
        List<Event> GetList();
    }
}
