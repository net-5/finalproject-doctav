using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISpeakersRepository
    {
        List<Speakers> GetAllSpeakers();
    }
    public class SpeakersRepository : ISpeakersRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SpeakersRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }
        public List<Speakers> GetAllSpeakers()
        {
            return conferenceContext.Speakers.ToList();
        }
    }
}
