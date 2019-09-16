using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IEditionsRepository
    {
        List<Editions> GetAllEditions();
        Editions AddEdition(Editions edition);
        Editions GetEditionById(int id);
        Editions Update(Editions editionToUpdate);
    }

    public class EditionRepository : IEditionsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public EditionRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Editions AddEdition(Editions edition)
        {
            var addedEdition = conferenceContext.Editions.Add(edition);
            conferenceContext.SaveChanges();
            return addedEdition.Entity;
        }

        public List<Editions> GetAllEditions()
        {
            return conferenceContext.Editions.ToList();
        }

        public Editions GetEditionById(int id)
        {
            return conferenceContext.Editions.Find(id);
        }

        public Editions Update(Editions editionToUpdate)
        {
            var updatedEdition = conferenceContext.Update(editionToUpdate);
            conferenceContext.SaveChanges();
            return updatedEdition.Entity;
        }
    }
}
