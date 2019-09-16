using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ITalksService
    {
        List<Talks> GetAllTalks();
    }
    public class TalksService : ITalksService
    {
        private readonly ITalksRepository talkRepository;

        public TalksService(ITalksRepository talkRepository)
        {
            this.talkRepository = talkRepository;
        }
        public List<Talks> GetAllTalks()
        {
            return talkRepository.GetAllTalks();
        }
    }
}
