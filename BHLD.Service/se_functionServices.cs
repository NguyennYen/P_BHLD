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
    public interface Ise_functionServices
    {
        void Add(se_function post);
        void Update(se_function post);
        void Delete(int id);
        IEnumerable<se_function> GetAll();
        IEnumerable<se_function> GetAllPaging(int page, int pageSize, out int totalRow);
        se_function GetById(int id);
        IEnumerable<se_function> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_functionServices : Ise_functionServices
    {
        se_functionRepository _se_functionRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_function post)
        {
            _se_functionRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_functionRepository.Delete(id);
        }

        public IEnumerable<se_function> GetAll()
        {
            return (IEnumerable<se_function>)_se_functionRepository.GetAll(new string[] { "Post_se_function" });
        }

        public IEnumerable<se_function> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return (IEnumerable<se_function>)_se_functionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_function> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return (IEnumerable<se_function>)_se_functionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_function GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_function post)
        {
            _se_functionRepository.Update(post);
        }
    }
}
