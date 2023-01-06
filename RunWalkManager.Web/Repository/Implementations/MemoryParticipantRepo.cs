using RunWalkManager.Models;
using RunWalkManager.Web.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Repository.Implementations
{
    public class MemoryParticipantRepo : IParticipantRepository
    {
        private List<Participant> particpants = new List<Participant>();

        public bool Create(Participant p)
        {
            if (p == null)
                return false;
            particpants.Add(p);
            return true;
        }

        public void Delete(Participant p)
        {
            if (p != null)
                Delete(p.identifier);
        }
       

        public void Delete(int id) =>
            particpants.RemoveAll(p => p.identifier == id);

        public Participant Read(int id) =>
            particpants.FirstOrDefault(p=>p.identifier==id);

        public bool Update(Participant p)
        {
            return true;
        }
    }
}
