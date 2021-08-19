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

        hu_employee Add(hu_employee hu_Employee);
        void Update(hu_employee hu_Employee);
        hu_employee Delete(int id);
        IEnumerable<hu_employee> GetAll();
        IEnumerable<hu_employee> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_employee GetById(int id);
        IEnumerable<hu_employee> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_employeeServices : Ihu_employeeServices
    {
        Ihu_employeeRepository _EmployeeRepository;
        IUnitOfWork _unitOfWork;
 
        public hu_employeeServices(hu_employeeRepository hu_EmployeeRepository, IUnitOfWork unitOfWork)
        {
            this._EmployeeRepository = hu_EmployeeRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_employee Add(hu_employee hu_Employee)
        {
            return _EmployeeRepository.Add(hu_Employee);
        }

        public hu_employee Delete(int id)
        {
            return _EmployeeRepository.Delete(id);
        }

        public IEnumerable<hu_employee> GetAll()
        {
            return _EmployeeRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_employee> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _EmployeeRepository.GetAllByEmployee(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_employee> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _EmployeeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_employee GetById(int id)
        {
            return _EmployeeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_employee hu_Employee)
        {
            _EmployeeRepository.Update(hu_Employee);
        }
    }
}
