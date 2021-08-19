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
        se_function_group Add(se_function_group se_Function_Group);
        void Update(se_function_group se_Function_Group);
        se_function_group Delete(int id);
        IEnumerable<se_function_group> GetAll();
        IEnumerable<se_function_group> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_function_group GetById(int id);
        IEnumerable<se_function_group> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class se_function_groupServices : Ise_function_groupServices
    {
        Ise_function_groupRepository _Function_GroupRepository;
        IUnitOfWork _unitOfWork;
        public se_function_groupServices(se_function_groupRepository se_FunctionGroupRepository, IUnitOfWork unitOfWork)
        {
            this._Function_GroupRepository = se_FunctionGroupRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_function_group Add(se_function_group se_Function_Group)
        {
            return _Function_GroupRepository.Add(se_Function_Group);
        }

        public se_function_group Delete(int id)
        {
            return _Function_GroupRepository.Delete(id);
        }

        public IEnumerable<se_function_group> GetAll()
        {
            return _Function_GroupRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_function_group> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Function_GroupRepository.GetAllByFunctionGroup(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_function_group> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Function_GroupRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_function_group GetById(int id)
        {
            return _Function_GroupRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_function_group se_Function_Group)
        {
            _Function_GroupRepository.Update(se_Function_Group);
        }
    }
}
