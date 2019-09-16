using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ITalksRepository
    {
        List<Talks> GetAllTalks();
    }
    public class TalksRepository : ITalksRepository
    {
        private readonly ConferenceContext conferenceContext;

        public TalksRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }
        public List<Talks> GetAllTalks()
        {
            return conferenceContext.Talks.ToList();        }
    }
}
