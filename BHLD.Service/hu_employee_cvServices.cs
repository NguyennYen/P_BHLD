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
        hu_employee_cv Add(hu_employee_cv hu_Employee_Cv);
        void Update(hu_employee_cv hu_Employee_Cv);
        hu_employee_cv Delete(int id);
        IEnumerable<hu_employee_cv> GetAll();
        IEnumerable<hu_employee_cv> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_employee_cv GetById(int id);
        IEnumerable<hu_employee_cv> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();



    }

    public class hu_employee_cvServices : Ihu_employee_cvServices
    {
        Ihu_employee_cvRepository _Employee_CvRepository;
        IUnitOfWork _unitOfWork;

        public hu_employee_cvServices(Ihu_employee_cvRepository ihu_Employee_CvRepository, IUnitOfWork unitOfWork)
        {
            this._Employee_CvRepository = ihu_Employee_CvRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_employee_cv Add(hu_employee_cv hu_Employee_Cv)
        {
            return _Employee_CvRepository.Add(hu_Employee_Cv);
        }

        public hu_employee_cv Delete(int id)
        {
            return _Employee_CvRepository.Delete(id);
        }

        public IEnumerable<hu_employee_cv> GetAll()
        {
            return _Employee_CvRepository.GetAll(new string[] { "Employee" });
        }

        public IEnumerable<hu_employee_cv> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Employee_CvRepository.GetAllByEmployee(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_employee_cv> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Employee_CvRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_employee_cv GetById(int id)
        {
            return _Employee_CvRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(hu_employee_cv hu_Employee_Cv)
        {
            _Employee_CvRepository.Update(hu_Employee_Cv);
        }
    }
}
