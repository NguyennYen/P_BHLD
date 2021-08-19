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
        se_user_permission Add(se_user_permission se_User_Permission);
        void Update(se_user_permission se_User_Permission);
        se_user_permission Delete(int id);
        IEnumerable<se_user_permission> GetAll();
        IEnumerable<se_user_permission> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_user_permission GetById(int id);
        IEnumerable<se_user_permission> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class se_user_permissionServices : Ise_user_permissionServices
    {
        Ise_user_permissionRepository _User_PermissionRepository;
        IUnitOfWork _unitOfWork;
        public se_user_permissionServices(se_user_permissionRepository se_User_PermissionRepository, IUnitOfWork unitOfWork)
        {
            this._User_PermissionRepository = se_User_PermissionRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_user_permission Add(se_user_permission se_User_Permission)
        {
            return _User_PermissionRepository.Add(se_User_Permission);
        }

        public se_user_permission Delete(int id)
        {
            return _User_PermissionRepository.Delete(id);
        }

        public IEnumerable<se_user_permission> GetAll()
        {
            return _User_PermissionRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_user_permission> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _User_PermissionRepository.GetAllByUserPermiss(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_user_permission> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _User_PermissionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_user_permission GetById(int id)
        {
            return _User_PermissionRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user_permission se_User_Permission)
        {
            _User_PermissionRepository.Update(se_User_Permission);
        }
    }
}
