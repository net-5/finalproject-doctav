using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISpeakerService
    {
        List<Speakers> GetAllSpeakers();
    }
    public class SpeakersService : ISpeakerService
    {
        private readonly ISpeakersRepository speakerRepository;

        public SpeakersService(ISpeakersRepository speakerRepository)
        {
            this.speakerRepository = speakerRepository;
        }
        public List<Speakers> GetAllSpeakers()
        {
            return speakerRepository.GetAllSpeakers();
        }
    }
}
