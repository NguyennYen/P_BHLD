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
        hu_protection Add(hu_protection hu_Protection);
        void Update(hu_protection hu_Protection);
        hu_protection Delete(int id);
        IEnumerable<hu_protection> GetAll();
        IEnumerable<hu_protection> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_protection GetById(int id);
        IEnumerable<hu_protection> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class hu_protectionServices : Ihu_protectionServices
    {
        Ihu_protectionRepository _ProtectionRepository;
        IUnitOfWork _unitOfWork;
        public hu_protectionServices(hu_protectionRepository hu_ProtectionRepository, IUnitOfWork unitOfWork)
        {
            this._ProtectionRepository = hu_ProtectionRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_protection Add(hu_protection hu_Protection)
        {
            return _ProtectionRepository.Add(hu_Protection);
        }

        public hu_protection Delete(int id)
        {
            return _ProtectionRepository.Delete(id);
        }

        public IEnumerable<hu_protection> GetAll()
        {
            return _ProtectionRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_protection> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _ProtectionRepository.GetAllByProtection(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_protection> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _ProtectionRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_protection GetById(int id)
        {
            return _ProtectionRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection hu_Protection)
        {
            _ProtectionRepository.Update(hu_Protection);
        }
    }
}
