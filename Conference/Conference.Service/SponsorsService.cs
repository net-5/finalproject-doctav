using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorsService
    {
        List<Sponsors> GetAllSponsors();
        Sponsors GetSponsorById(int id);
        Sponsors AddSponsors(Sponsors sponsorToAdd);
        Sponsors UpdateSponsors(Sponsors sponsorToUpdate);
        void DeleteSponsor(Sponsors sponsorToDelete);
    }
    public class SponsorsService : ISponsorsService
    {
        private readonly ISponsorsRepository sponsorsRepository;

        public SponsorsService(ISponsorsRepository sponsorsRepository)
        {
            this.sponsorsRepository = sponsorsRepository;
        }

        public Sponsors AddSponsors(Sponsors sponsorToAdd)
        {
            return sponsorsRepository.AddSponsor(sponsorToAdd);
        }

        public void DeleteSponsor(Sponsors sponsorToDelete)
        {
            sponsorsRepository.DeleteSponsor(sponsorToDelete);
        }

        public List<Sponsors> GetAllSponsors()
        {
            return sponsorsRepository.GetAllSponsors();
        }

        public Sponsors GetSponsorById(int id)
        {
            return sponsorsRepository.GetSponsorsById(id);
        }

        public Sponsors UpdateSponsors(Sponsors sponsorToUpdate)
        {
            return sponsorsRepository.UpdateSponsor(sponsorToUpdate);
        }
    }
}
