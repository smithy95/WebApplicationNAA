using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data;
using NAA.Data.IDAO;
using NAA.Data.DAO;
using NAA.Service.IService;

namespace NAA.Service.Service
{
    public class ProfileService : IProfileService
    {
        private IProfileDAO profileDAO;

        public ProfileService()
        {
            profileDAO = new ProfileDAO();
        }

        public Profile GetProfile()
        {

            return profileDAO.GetProfile();
        }
    }
}
