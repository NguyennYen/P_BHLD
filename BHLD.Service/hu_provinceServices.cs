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
    public interface Ihu_provinceServices
    {
        void Add(hu_province post);
        void Update(hu_province post);
        void Delete(int id);
        IEnumerable<hu_province> GetAll();
        IEnumerable<hu_province> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_province GetById(int id);
        IEnumerable<hu_province> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_provinceServices : Ihu_provinceServices
    {
        hu_provinceRepository _hu_provinceRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_province post)
        {
            _hu_provinceRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_provinceRepository.Delete(id);
        }

        public IEnumerable<hu_province> GetAll()
        {
            return _hu_provinceRepository.GetAll(new string[] { "Post_hu_province" });
        }

        public IEnumerable<hu_province> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_provinceRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_province> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_provinceRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_province GetById(int id)
        {
            return _hu_provinceRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_province post)
        {
            _hu_provinceRepository.Update(post);
        }
    }
}
