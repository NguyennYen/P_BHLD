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
        void Add(synthetic post);
        void Update(synthetic post);
        void Delete(int id);
        IEnumerable<synthetic> GetAll();
        IEnumerable<synthetic> GetAllPaging(int page, int pageSize, out int totalRow);
        synthetic GetById(int id);
        IEnumerable<synthetic> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class syntheticServices : IsyntheticServices
    {
        syntheticRepository _syntheticRepository;
        IUnitOfWork _unitOfWork;
        public void Add(synthetic post)
        {
            _syntheticRepository.Add(post);
        }

        public void Delete(int id)
        {
            _syntheticRepository.Delete(id);
        }

        public IEnumerable<synthetic> GetAll()
        {
            return _syntheticRepository.GetAll(new string[] { "Post_synthetic" });
        }

        public IEnumerable<synthetic> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _syntheticRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
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

        public void Update(synthetic post)
        {
            _syntheticRepository.Update(post);
        }
    }
}
