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
    public interface Ihu_employee_cvServices
    {
        void Add(hu_employee_cv post);
        void Update(hu_employee_cv post);
        void Delete(int id);
        IEnumerable<hu_employee_cv> GetAll();
        IEnumerable<hu_employee_cv> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_employee_cv GetById(int id);
        IEnumerable<hu_employee_cv> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();

        
    }

    public class hu_employee_cvServices : Ihu_employee_cvServices
    {
        hu_employee_cvRepository _hu_Employee_cvRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_employee_cv post)
        {
            _hu_Employee_cvRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_Employee_cvRepository.Delete(id);
        }

        public IEnumerable<hu_employee_cv> GetAll()
        {
            return (IEnumerable<hu_employee_cv>)_hu_Employee_cvRepository.GetAll(new string[] { "Post_hu_employee_cv" });
        }

        public IEnumerable<hu_employee_cv> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return (IEnumerable<hu_employee_cv>)_hu_Employee_cvRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_employee_cv> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return (IEnumerable<hu_employee_cv>)_hu_Employee_cvRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_employee_cv GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_employee_cv post)
        {
            _hu_Employee_cvRepository.Update(post);
        }
    }
}
