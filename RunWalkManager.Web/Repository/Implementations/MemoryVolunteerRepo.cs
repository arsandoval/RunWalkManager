using RunWalkManager.Models;
using RunWalkManager.Web.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Repository.Implementations
{
    public class MemoryVolunteerRepo : IVolunteerRepository
    {
        private List<Volunteer> volunteers = new List<Volunteer>();

        public bool Create(Volunteer v)
        {
            if (v == null)
                return false;
            volunteers.Add(v);
            return true;
        }

        public void Delete(Volunteer v)
        {
            if (v != null)
                Delete(v.identifier);
        }

        public void Delete(int id) =>
            volunteers.RemoveAll(v => v.identifier == id);

        public Volunteer Read(int id) =>
            volunteers.FirstOrDefault(v => v.identifier == id);

        public bool Update(Volunteer v)
        {
            return true;
        }
    }
}
