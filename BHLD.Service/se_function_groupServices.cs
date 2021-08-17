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
    public interface Ise_function_groupServices
    {
        void Add(se_function_group post);
        void Update(se_function_group post);
        void Delete(int id);
        IEnumerable<se_function_group> GetAll();
        IEnumerable<se_function_group> GetAllPaging(int page, int pageSize, out int totalRow);
        se_function_group GetById(int id);
        IEnumerable<se_function_group> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_function_groupServices : Ise_function_groupServices
    {
        se_function_groupRepository _se_function_groupRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_function_group post)
        {
            _se_function_groupRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_function_groupRepository.Delete(id);
        }

        public IEnumerable<se_function_group> GetAll()
        {
            return _se_function_groupRepository.GetAll(new string[] { "Post_se_function_group" });
        }

        public IEnumerable<se_function_group> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _se_function_groupRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_function_group> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _se_function_groupRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_function_group GetById(int id)
        {
            return _se_function_groupRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_function_group post)
        {
            _se_function_groupRepository.Update(post);
        }
    }
}
