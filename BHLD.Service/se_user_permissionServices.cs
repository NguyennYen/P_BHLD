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
    public interface Ise_user_permissionServices
    {
        void Add(se_user_permission post);
        void Update(se_user_permission post);
        void Delete(int id);
        IEnumerable<se_user_permission> GetAll();
        IEnumerable<se_user_permission> GetAllPaging(int page, int pageSize, out int totalRow);
        se_user_permission GetById(int id);
        IEnumerable<se_user_permission> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_user_permissionServices : Ise_user_permissionServices
    {
        se_user_permissionRepository _se_user_permissionRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_user_permission post)
        {
            _se_user_permissionRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_user_permissionRepository.Delete(id);
        }

        public IEnumerable<se_user_permission> GetAll()
        {
            return _se_user_permissionRepository.GetAll(new string[] { "Post_se_user_permission" });
        }

        public IEnumerable<se_user_permission> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _se_user_permissionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_user_permission> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _se_user_permissionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_user_permission GetById(int id)
        {
            return _se_user_permissionRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user_permission post)
        {
            _se_user_permissionRepository.Update(post);
        }
    }
}
