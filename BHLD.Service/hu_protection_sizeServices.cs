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
    public interface Ihu_protection_sizeServices
    {
        hu_protection_size Add(hu_protection_size hu_Protection_Size);
        void Update(hu_protection_size hu_Protection_Size);
        hu_protection_size Delete(int id);
        IEnumerable<hu_protection_size> GetAll();
        IEnumerable<hu_protection_size> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_protection_size GetById(int id);
        IEnumerable<hu_protection_size> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_sizeServices : Ihu_protection_sizeServices
    {
        Ihu_protection_sizeRepository _Protection_SizeRepository;
        IUnitOfWork _unitOfWork;
        public hu_protection_sizeServices(hu_protection_sizeRepository hu_Protection_SizeRepository, IUnitOfWork unitOfWork)
        {
            this._Protection_SizeRepository = hu_Protection_SizeRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_protection_size Add(hu_protection_size hu_Protection_Size)
        {
            return _Protection_SizeRepository.Add(hu_Protection_Size);
        }

        public hu_protection_size Delete(int id)
        {
            return _Protection_SizeRepository.Delete(id);
        }

        public IEnumerable<hu_protection_size> GetAll()
        {
            return _Protection_SizeRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_protection_size> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Protection_SizeRepository.GetAllByProtectionSize(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_protection_size> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Protection_SizeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_protection_size GetById(int id)
        {
            return _Protection_SizeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_size hu_Protection_Size)
        {
            _Protection_SizeRepository.Update(hu_Protection_Size);
        }
    }
}
