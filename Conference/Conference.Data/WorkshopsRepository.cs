using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IWorkshopsRepository
    {
        List<Workshops> GetAllWorkshops();
    }
    public class WorkshopsRepository : IWorkshopsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public WorkshopsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }
        public List<Workshops> GetAllWorkshops()
        {
            return conferenceContext.Workshops.ToList();
        }
    }
}
