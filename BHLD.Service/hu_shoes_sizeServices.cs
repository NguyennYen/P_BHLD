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
    public interface Ihu_shoes_sizeServices
    {
        void Add(hu_shoes_size post);
        void Update(hu_shoes_size post);
        void Delete(int id);
        IEnumerable<hu_shoes_size> GetAll();
        IEnumerable<hu_shoes_size> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_shoes_size GetById(int id);
        IEnumerable<hu_shoes_size> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_shoes_sizeServices : Ihu_shoes_sizeServices
    {
        hu_shoes_sizeRepository _hu_shoes_sizeRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_shoes_size post)
        {
            _hu_shoes_sizeRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_shoes_sizeRepository.Delete(id);
        }

        public IEnumerable<hu_shoes_size> GetAll()
        {
            return _hu_shoes_sizeRepository.GetAll(new string[] { "Post_hu_shoes_size" });
        }

        public IEnumerable<hu_shoes_size> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_shoes_sizeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_shoes_size> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_shoes_sizeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_shoes_size GetById(int id)
        {
            return _hu_shoes_sizeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_shoes_size post)
        {
            _hu_shoes_sizeRepository.Update(post);
        }
    }
}
