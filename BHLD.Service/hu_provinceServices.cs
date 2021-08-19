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
        hu_province Add(hu_province hu_Province);
        void Update(hu_province hu_Province);
        hu_province Delete(int id);
        IEnumerable<hu_province> GetAll();
        IEnumerable<hu_province> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_province GetById(int id);
        IEnumerable<hu_province> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class hu_provinceServices : Ihu_provinceServices
    {
        Ihu_provinceRepository _ProvinceRepository;
        IUnitOfWork _unitOfWork;
        public hu_provinceServices(hu_provinceRepository hu_ProvinceRepository, IUnitOfWork unitOfWork)
        {
            this._ProvinceRepository = hu_ProvinceRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_province Add(hu_province hu_Province)
        {
            return _ProvinceRepository.Add(hu_Province);
        }

        public hu_province Delete(int id)
        {
            return _ProvinceRepository.Delete(id);
        }

        public IEnumerable<hu_province> GetAll()
        {
            return _ProvinceRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_province> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _ProvinceRepository.GetAllByProvince(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_province> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _ProvinceRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_province GetById(int id)
        {
            return _ProvinceRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_province hu_Province)
        {
            _ProvinceRepository.Update(hu_Province);
        }
    }
}
