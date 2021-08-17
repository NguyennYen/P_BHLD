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
    public interface Ihu_titleServices
    {
        void Add(hu_title post);
        void Update(hu_title post);
        void Delete(int id);
        IEnumerable<hu_title> GetAll();
        IEnumerable<hu_title> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_title GetById(int id);
        IEnumerable<hu_title> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_titleServices : Ihu_titleServices
    {
        hu_titleRepository _hu_titleRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_title post)
        {
            _hu_titleRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_titleRepository.Delete(id);
        }

        public IEnumerable<hu_title> GetAll()
        {
            return _hu_titleRepository.GetAll(new string[] { "Post_hu_title" });
        }

        public IEnumerable<hu_title> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_titleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_title> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_titleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_title GetById(int id)
        {
            return _hu_titleRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_title post)
        {
            _hu_titleRepository.Update(post);
        }
    }
}
