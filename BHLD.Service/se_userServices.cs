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
    public interface Ise_userServices
    {
        se_user Add(se_user se_User);
        void Update(se_user se_User);
        se_user Delete(int id);
        IEnumerable<se_user> GetAll();
        IEnumerable<se_user> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_user GetById(int id);
        IEnumerable<se_user> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class se_userServices : Ise_userServices
    {
        Ise_userRepository _UserRepository;
        IUnitOfWork _unitOfWork;
        public se_userServices(Se_userRepository se_UserRepository, IUnitOfWork unitOfWork)
        {
            this._UserRepository = se_UserRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_user Add(se_user se_User)
        {
            return _UserRepository.Add(se_User);
        }

        public se_user Delete(int id)
        {
            return _UserRepository.Delete(id);
        }

        public IEnumerable<se_user> GetAll()
        {
            return _UserRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_user> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _UserRepository.GetAllByUser(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_user> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _UserRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_user GetById(int id)
        {
            return _UserRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user se_User)
        {
            _UserRepository.Update(se_User);
        }
    }
}
