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
    public interface Ihu_nationServices
    {
        void Add(hu_nation post);
        void Update(hu_nation post);
        void Delete(int id);
        IEnumerable<hu_nation> GetAll();
        IEnumerable<hu_nation> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_nation GetById(int id);
        IEnumerable<hu_nation> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_nationServices : Ihu_nationServices
    {
        hu_nationRepository _hu_nationRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_nation post)
        {
            _hu_nationRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_nationRepository.Delete(id);
        }

        public IEnumerable<hu_nation> GetAll()
        {
            return _hu_nationRepository.GetAll(new string[] { "Post_hu_nation" });
        }

        public IEnumerable<hu_nation> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_nationRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_nation> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_nationRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_nation GetById(int id)
        {
            return _hu_nationRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_nation post)
        {
            _hu_nationRepository.Update(post);
        }
    }
}
