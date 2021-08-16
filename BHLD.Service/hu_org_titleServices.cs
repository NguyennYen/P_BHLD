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
   
    public interface Ihu_org_titleServices
    {
        void Add(hu_org_title post);
        void Update(hu_org_title post);
        void Delete(int id);
        IEnumerable<hu_org_title> GetAll();
        IEnumerable<hu_org_title> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_org_title GetById(int id);
        IEnumerable<hu_org_title> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_org_titleServices : Ihu_org_titleServices
    {
        hu_org_titleRepository _hu_org_titleRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_org_title post)
        {
            _hu_org_titleRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_org_titleRepository.Delete(id);
        }

        public IEnumerable<hu_org_title> GetAll()
        {
            return _hu_org_titleRepository.GetAll(new string[] { "Post_hu_org_title" });
        }

        public IEnumerable<hu_org_title> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_org_titleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_org_title> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_org_titleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_org_title GetById(int id)
        {
            return _hu_org_titleRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_org_title post)
        {
            _hu_org_titleRepository.Update(post);
        }
    }
}
