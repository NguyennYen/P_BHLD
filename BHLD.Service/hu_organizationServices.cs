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
        hu_organization Add(hu_organization hu_Organization);
        void Update(hu_organization hu_Organization);
        hu_organization Delete(int id);
        IEnumerable<hu_organization> GetAll();
        IEnumerable<hu_organization> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_organization GetById(int id);
        IEnumerable<hu_organization> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_organizationServices : Ihu_organizationServices
    {
        Ihu_organizationRepository _OrganizationRepository;
        IUnitOfWork _unitOfWork;
        public hu_organizationServices(hu_organizationRepository hu_OrganizationRepository, IUnitOfWork unitOfWork)
        {
            this._OrganizationRepository = hu_OrganizationRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_organization Add(hu_organization hu_Organization)
        {
            return _OrganizationRepository.Add(hu_Organization);
        }

        public hu_organization Delete(int id)
        {
            return _OrganizationRepository.Delete(id);
        }

        public IEnumerable<hu_organization> GetAll()
        {
            return _OrganizationRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_organization> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _OrganizationRepository.GetAllByOrg(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_organization> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _OrganizationRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        
        }



        public hu_organization GetById(int id)
        {
            return _OrganizationRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_organization hu_Organization)
        {
            _OrganizationRepository.Update(hu_Organization);
        }
    }
}
