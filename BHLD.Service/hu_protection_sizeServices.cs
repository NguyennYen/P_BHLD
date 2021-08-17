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
    public interface Ihu_protection_sizeServices
    {
        void Add(hu_protection_size post);
        void Update(hu_protection_size post);
        void Delete(int id);
        IEnumerable<hu_protection_size> GetAll();
        IEnumerable<hu_protection_size> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_protection_size GetById(int id);
        IEnumerable<hu_protection_size> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_sizeServices : Ihu_protection_sizeServices
    {
        hu_protection_sizeRepository _hu_protection_sizeRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_protection_size post)
        {
            _hu_protection_sizeRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_protection_sizeRepository.Delete(id);
        }

        public IEnumerable<hu_protection_size> GetAll()
        {
            return _hu_protection_sizeRepository.GetAll(new string[] { "Post_hu_protection_size" });
        }

        public IEnumerable<hu_protection_size> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_protection_sizeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_protection_size> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_protection_sizeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_protection_size GetById(int id)
        {
            return _hu_protection_sizeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_size post)
        {
            _hu_protection_sizeRepository.Update(post);
        }
    }
}
