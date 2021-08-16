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
    public interface Ihu_protection_empServices
    {
        void Add(hu_protection_emp post);
        void Update(hu_protection_emp post);
        void Delete(int id);
        IEnumerable<hu_protection_emp> GetAll();
        IEnumerable<hu_protection_emp> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_protection_emp GetById(int id);
        IEnumerable<hu_protection_emp> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_empServices : Ihu_protection_empServices
    {
        hu_protection_empRepository _hu_protection_empRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_protection_emp post)
        {
            _hu_protection_empRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_protection_empRepository.Delete(id);
        }

        public IEnumerable<hu_protection_emp> GetAll()
        {
            return _hu_protection_empRepository.GetAll(new string[] { "Post_hu_protection_emp" });
        }

        public IEnumerable<hu_protection_emp> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_protection_empRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_protection_emp> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_protection_empRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_protection_emp GetById(int id)
        {
            return _hu_protection_empRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_emp post)
        {
            _hu_protection_empRepository.Update(post);
        }
    }
}
