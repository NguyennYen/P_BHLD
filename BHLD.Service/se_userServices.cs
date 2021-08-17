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
        void Add(se_user post);
        void Update(se_user post);
        void Delete(int id);
        IEnumerable<se_user> GetAll();
        IEnumerable<se_user> GetAllPaging(int page, int pageSize, out int totalRow);
        se_user GetById(int id);
        IEnumerable<se_user> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_userServices : Ise_userServices
    {
        se_userRepository _se_userRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_user post)
        {
            _se_userRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_userRepository.Delete(id);
        }

        public IEnumerable<se_user> GetAll()
        {
            return _se_userRepository.GetAll(new string[] { "Post_se_user" });
        }

        public IEnumerable<se_user> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _se_userRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_user> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _se_userRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_user GetById(int id)
        {
            return _se_userRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user post)
        {
            _se_userRepository.Update(post);
        }
    }
}
