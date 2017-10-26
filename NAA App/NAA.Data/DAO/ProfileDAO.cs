using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;

namespace NAA.Data.DAO
{
    public class ProfileDAO : IProfileDAO
    {
        private DataEntities context;

        public ProfileDAO()
        {
            context = new DataEntities();
        }

        public Profile GetProfile()
        {
            IQueryable<Profile> Profiles;

            Profiles = from prof
                       in context.Profile
                       select prof;

            return Profiles.FirstOrDefault();
        }
    }
}
