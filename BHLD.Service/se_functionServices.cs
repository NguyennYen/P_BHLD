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
        se_function Add(se_function se_Function);
        void Update(se_function se_Function);
        se_function Delete(int id);
        IEnumerable<se_function> GetAll();
        IEnumerable<se_function> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_function GetById(int id);
        IEnumerable<se_function> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class se_functionServices : Ise_functionServices
    {
        Ise_functionRepository _FunctionRepository;
        IUnitOfWork _unitOfWork;
        public se_functionServices(se_functionRepository se_FunctionRepository, IUnitOfWork unitOfWork)
        {
            this._FunctionRepository = se_FunctionRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_function Add(se_function se_Function)
        {
            return _FunctionRepository.Add(se_Function);
        }

        public se_function Delete(int id)
        {
            return _FunctionRepository.Delete(id);
        }

        public IEnumerable<se_function> GetAll()
        {
            return _FunctionRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_function> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _FunctionRepository.GetAllByFunction(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_function> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _FunctionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_function GetById(int id)
        {
            return _FunctionRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_function se_Function)
        {
            _FunctionRepository.Update(se_Function);
        }
    }
}
