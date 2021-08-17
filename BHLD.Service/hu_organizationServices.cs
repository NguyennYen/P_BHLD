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
    
    public interface Ihu_organizationServices
    {
        void Add(hu_organization post);
        void Update(hu_organization post);
        void Delete(int id);
        IEnumerable<hu_organization> GetAll();
        IEnumerable<hu_organization> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_organization GetById(int id);
        IEnumerable<hu_organization> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_organizationServices : Ihu_organizationServices
    {
        hu_organizationRepository _hu_organizationRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_organization post)
        {
            _hu_organizationRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_organizationRepository.Delete(id);
        }

        public IEnumerable<hu_organization> GetAll()
        {
            return _hu_organizationRepository.GetAll(new string[] { "Post_hu_organization" });
        }

        public IEnumerable<hu_organization> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_organizationRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_organization> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_organizationRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_organization GetById(int id)
        {
            return _hu_organizationRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_organization post)
        {
            _hu_organizationRepository.Update(post);
        }
    }
}
