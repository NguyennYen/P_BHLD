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
    
    public interface Ihu_employeeServices
    {
        void Add(hu_employee post);
        void Update(hu_employee post);
        void Delete(int id);
        IEnumerable<hu_employee> GetAll();
        IEnumerable<hu_employee> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_employee GetById(int id);
        IEnumerable<hu_employee> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_employeeServices : Ihu_employeeServices
    {
        hu_employeeRepository _hu_employeeRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_employee post)
        {
            _hu_employeeRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_employeeRepository.Delete(id);
        }

        public IEnumerable<hu_employee> GetAll()
        {
            return _hu_employeeRepository.GetAll(new string[] { "Post_hu_employee" });
        }

        public IEnumerable<hu_employee> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_employeeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_employee> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_employeeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_employee GetById(int id)
        {
            return _hu_employeeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_employee post)
        {
            _hu_employeeRepository.Update(post);
        }
    }
}
