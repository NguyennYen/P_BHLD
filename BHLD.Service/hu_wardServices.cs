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
    public interface Ihu_wardServices
    {
        void Add(hu_ward post);
        void Update(hu_ward post);
        void Delete(int id);
        IEnumerable<hu_ward> GetAll();
        IEnumerable<hu_ward> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_ward GetById(int id);
        IEnumerable<hu_ward> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_wardServices : Ihu_wardServices
    {
        hu_wardRepository _hu_wardRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_ward post)
        {
            _hu_wardRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_wardRepository.Delete(id);
        }

        public IEnumerable<hu_ward> GetAll()
        {
            return _hu_wardRepository.GetAll(new string[] { "Post_hu_ward" });
        }

        public IEnumerable<hu_ward> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_wardRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_ward> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_wardRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_ward GetById(int id)
        {
            return _hu_wardRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_ward post)
        {
            _hu_wardRepository.Update(post);
        }
    }
}
