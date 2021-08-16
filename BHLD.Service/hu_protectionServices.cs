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
    public interface Ihu_protectionServices
    {
        void Add(hu_protection post);
        void Update(hu_protection post);
        void Delete(int id);
        IEnumerable<hu_protection> GetAll();
        IEnumerable<hu_protection> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_protection GetById(int id);
        IEnumerable<hu_protection> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protectionServices : Ihu_protectionServices
    {
        hu_protectionRepository _hu_protectionRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_protection post)
        {
            _hu_protectionRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_protectionRepository.Delete(id);
        }

        public IEnumerable<hu_protection> GetAll()
        {
            return _hu_protectionRepository.GetAll(new string[] { "Post_hu_protection" });
        }

        public IEnumerable<hu_protection> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_protectionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_protection> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_protectionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_protection GetById(int id)
        {
            return _hu_protectionRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection post)
        {
            _hu_protectionRepository.Update(post);
        }
    }
}
