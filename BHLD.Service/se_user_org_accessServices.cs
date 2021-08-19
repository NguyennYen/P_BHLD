using BHLD.Data.Infrastructure;
using BHLD.Data.Repositories;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Services
{
    public interface Ise_user_org_accessServices
    {
        se_user_org_access Add(se_user_org_access se_User_Org_Access);
        void Update(se_user_org_access se_User_Org_Access);
        se_user_org_access Delete(int id);
        IEnumerable<se_user_org_access> GetAll();
        IEnumerable<se_user_org_access> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_user_org_access GetById(int id);
        IEnumerable<se_user_org_access> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class se_user_org_accessServices : Ise_user_org_accessServices
    {
        Ise_user_org_accessRepository _User_Org_AccessRepository;
        IUnitOfWork _unitOfWork;
        public se_user_org_accessServices(se_user_org_accessRepository se_User_Org_AccessRepository, IUnitOfWork unitOfWork)
        {
            this._User_Org_AccessRepository = se_User_Org_AccessRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_user_org_access Add(se_user_org_access se_User_Org_Access)
        {
            return _User_Org_AccessRepository.Add(se_User_Org_Access);
        }

        public se_user_org_access Delete(int id)
        {
            return _User_Org_AccessRepository.Delete(id);
        }

        public IEnumerable<se_user_org_access> GetAll()
        {
            return _User_Org_AccessRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_user_org_access> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _User_Org_AccessRepository.GetAllByUserOrg(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_user_org_access> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _User_Org_AccessRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_user_org_access GetById(int id)
        {
            return _User_Org_AccessRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user_org_access se_User_Org_Access)
        {
            _User_Org_AccessRepository.Update(se_User_Org_Access);
        }
    }
}
