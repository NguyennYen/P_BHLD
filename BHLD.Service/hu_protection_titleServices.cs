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
    public interface Ihu_protection_titleServices
    {
        void Add(hu_protection_title post);
        void Update(hu_protection_title post);
        void Delete(int id);
        IEnumerable<hu_protection_title> GetAll();
        IEnumerable<hu_protection_title> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_protection_title GetById(int id);
        IEnumerable<hu_protection_title> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_titleServices : Ihu_protection_titleServices
    {
        hu_protection_titleRepository _hu_protection_titleRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_protection_title post)
        {
            _hu_protection_titleRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_protection_titleRepository.Delete(id);
        }

        public IEnumerable<hu_protection_title> GetAll()
        {
            return _hu_protection_titleRepository.GetAll(new string[] { "Post_hu_protection_title" });
        }

        public IEnumerable<hu_protection_title> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_protection_titleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_protection_title> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_protection_titleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_protection_title GetById(int id)
        {
            return _hu_protection_titleRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_title post)
        {
            _hu_protection_titleRepository.Update(post);
        }
    }
}
