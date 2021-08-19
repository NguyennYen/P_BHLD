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
    public interface IsyntheticServices
    {
        synthetic Add(synthetic synthetic);
        void Update(synthetic synthetic);
        synthetic Delete(int id);
        IEnumerable<synthetic> GetAll();
        IEnumerable<synthetic> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        synthetic GetById(int id);
        IEnumerable<synthetic> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class syntheticServices : IsyntheticServices
    {
        IsyntheticRepository _syntheticRepository;
        IUnitOfWork _unitOfWork;
        public syntheticServices(syntheticRepository  syntheticRepository,UnitOfWork unitOfWork)
        {
            this._syntheticRepository = syntheticRepository;
            this._unitOfWork = unitOfWork;
        }

        public synthetic Add(synthetic synthetic)
        {
            return _syntheticRepository.Add(synthetic);
        }

        public synthetic Delete(int id)
        {
            return _syntheticRepository.Delete(id);
        }

        public IEnumerable<synthetic> GetAll()
        {
            return _syntheticRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<synthetic> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _syntheticRepository.GetAllBySynthetic(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<synthetic> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _syntheticRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public synthetic GetById(int id)
        {
            return _syntheticRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(synthetic synthetic)
        {
            _syntheticRepository.Update(synthetic);
        }
    }
}
