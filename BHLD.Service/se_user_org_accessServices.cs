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
        void Add(se_user_org_access post);
        void Update(se_user_org_access post);
        void Delete(int id);
        IEnumerable<se_user_org_access> GetAll();
        IEnumerable<se_user_org_access> GetAllPaging(int page, int pageSize, out int totalRow);
        se_user_org_access GetById(int id);
        IEnumerable<se_user_org_access> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_user_org_accessServices : Ise_user_org_accessServices
    {
        se_user_org_accessRepository _se_user_org_accessRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_user_org_access post)
        {
            _se_user_org_accessRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_user_org_accessRepository.Delete(id);
        }

        public IEnumerable<se_user_org_access> GetAll()
        {
            return _se_user_org_accessRepository.GetAll(new string[] { "Post_se_user_org_access" });
        }

        public IEnumerable<se_user_org_access> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _se_user_org_accessRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_user_org_access> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _se_user_org_accessRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_user_org_access GetById(int id)
        {
            return _se_user_org_accessRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user_org_access post)
        {
            _se_user_org_accessRepository.Update(post);
        }
    }
}
