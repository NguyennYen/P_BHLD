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
        hu_protection_emp Add(hu_protection_emp hu_Employee);
        void Update(hu_protection_emp hu_Employee);
        hu_protection_emp Delete(int id);
        IEnumerable<hu_protection_emp> GetAll();
        IEnumerable<hu_protection_emp> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_protection_emp GetById(int id);
        IEnumerable<hu_protection_emp> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_empServices : Ihu_protection_empServices
    {
        Ihu_protection_empRepository _Protection_EmpRepository;
        IUnitOfWork _unitOfWork;
        public hu_protection_empServices(hu_protection_empRepository hu_Protection_EmpRepository, IUnitOfWork unitOfWork)
        {
            this._Protection_EmpRepository = hu_Protection_EmpRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_protection_emp Add(hu_protection_emp hu_Title)
        {
            return _Protection_EmpRepository.Add(hu_Title);
        }

        public hu_protection_emp Delete(int id)
        {
            return _Protection_EmpRepository.Delete(id);
        }

        public IEnumerable<hu_protection_emp> GetAll()
        {
            return _Protection_EmpRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_protection_emp> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Protection_EmpRepository.GetAllByProtection(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_protection_emp> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Protection_EmpRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_protection_emp GetById(int id)
        {
            return _Protection_EmpRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    
        public void Update(hu_protection_emp hu_District)
        {
            _Protection_EmpRepository.Update(hu_District);
        }
    }
}
