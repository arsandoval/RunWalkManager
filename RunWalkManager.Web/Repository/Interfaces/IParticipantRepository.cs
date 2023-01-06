using RunWalkManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Repository.Interfaces
{
    public interface IParticipantRepository
    {
        public Boolean Create(Participant p);
        public Participant Read(int id);
        public Boolean Update(Participant p);
        public void Delete(Participant p);
        public void Delete(int id);
    }
}
