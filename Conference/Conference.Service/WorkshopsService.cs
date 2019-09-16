using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface IWorkshopService
    {
        List<Workshops> GetAllWorkshops();
    }
    public class WorkshopsService : IWorkshopService
    {
        private readonly IWorkshopsRepository workshopRepository;

        public WorkshopsService(IWorkshopsRepository workshopRepository)
        {
            this.workshopRepository = workshopRepository;
        }
        public List<Workshops> GetAllWorkshops()
        {
            return workshopRepository.GetAllWorkshops();
        }
    }
}
