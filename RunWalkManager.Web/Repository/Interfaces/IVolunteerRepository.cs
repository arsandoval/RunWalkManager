using RunWalkManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Repository.Interfaces
{
    public interface IVolunteerRepository
    {
        public Boolean Create(Volunteer v);
        public Volunteer Read(int id);
        public Boolean Update(Volunteer v);
        public void Delete(Volunteer v);
        public void Delete(int id);
    }
}
