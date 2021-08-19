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
    public interface Ihu_shoes_sizeServices
    {
        hu_shoes_size Add(hu_shoes_size hu_Shoes_Size);
        void Update(hu_shoes_size hu_Shoes_Size);
        hu_shoes_size Delete(int id);
        IEnumerable<hu_shoes_size> GetAll();
        IEnumerable<hu_shoes_size> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_shoes_size GetById(int id);
        IEnumerable<hu_shoes_size> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class hu_shoes_sizeServices : Ihu_shoes_sizeServices
    {
        Ihu_shoes_sizeRepository _Shoes_SizeRepository;
        IUnitOfWork _unitOfWork;
        public hu_shoes_sizeServices(hu_shoes_sizeRepository hu_Shoes_SizeRepository, IUnitOfWork unitOfWork)
        {
            this._Shoes_SizeRepository = hu_Shoes_SizeRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_shoes_size Add(hu_shoes_size hu_Shoes_Size)
        {
            return _Shoes_SizeRepository.Add(hu_Shoes_Size);
        }

        public hu_shoes_size Delete(int id)
        {
            return _Shoes_SizeRepository.Delete(id);
        }

        public IEnumerable<hu_shoes_size> GetAll()
        {
            return _Shoes_SizeRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_shoes_size> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Shoes_SizeRepository.GetAllByShoesSize(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_shoes_size> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Shoes_SizeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_shoes_size GetById(int id)
        {
            return _Shoes_SizeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_shoes_size hu_Shoes_Size)
        {
            _Shoes_SizeRepository.Update(hu_Shoes_Size);
        }
    }
}
