using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorTypesService
    {
        List<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes GetSponsorTypesById(int id);
        SponsorTypes AddSponsorTypes(SponsorTypes sponsorTypeToAdd);
        SponsorTypes UpdateSponsorTypes(SponsorTypes sponsorTypeToUpdate);
        void DeleteSponsorTypes(SponsorTypes sponsorTypeToDelete);
    }
    public class SponsorTypesService : ISponsorTypesService
    {
        private readonly ISponsorTypesRepository sponsorTypesRepository;

        public SponsorTypesService(ISponsorTypesRepository sponsorTypesRepository)
        {
            this.sponsorTypesRepository = sponsorTypesRepository;
        }

        public SponsorTypes AddSponsorTypes(SponsorTypes sponsorTypeToAdd)
        {
            var addedSponsorTypes = sponsorTypesRepository.AddSponsorTypes(sponsorTypeToAdd);
            return addedSponsorTypes;
        }

        public void DeleteSponsorTypes(SponsorTypes sponsorTypeToDelete)
        {
            sponsorTypesRepository.DeleteSponsorTypes(sponsorTypeToDelete);
        }

        public List<SponsorTypes> GetAllSponsorTypes()
        {
            return sponsorTypesRepository.GetAllSponsorTypes();
        }

        public SponsorTypes GetSponsorTypesById(int id)
        {
            return sponsorTypesRepository.GetSponsorTypeById(id);
        }

        public SponsorTypes UpdateSponsorTypes(SponsorTypes sponsorTypeToUpdate)
        {
            return sponsorTypesRepository.UpdateSponsorTypes(sponsorTypeToUpdate);
        }
    }
}
