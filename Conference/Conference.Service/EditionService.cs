using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{

    public interface IEditionService
    {
        List<Editions> GetAllEditions();
        Editions AddEdition(Editions edition);
        Editions GetEditionById(int id);
        Editions Update(Editions editionToUpdate);
    }
    public class EditionService : IEditionService
    {


        private readonly IEditionsRepository editionRepository;

        public EditionService(IEditionsRepository editionRepository)
        {
            this.editionRepository = editionRepository;
        }

        public Editions AddEdition(Editions edition)
        {
            Editions addedEdition = editionRepository.AddEdition(edition);
            return addedEdition;
        }

        public List<Editions> GetAllEditions()
        {
            return editionRepository.GetAllEditions();
        }

        public Editions GetEditionById(int id)
        {
            return editionRepository.GetEditionById(id);
        }

        public Editions Update(Editions editionToUpdate)
        {
            return editionRepository.Update(editionToUpdate);
        }
    }
}
