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
    public interface Ihu_wardServices
    {
        hu_ward Add(hu_ward hu_Ward);
        void Update(hu_ward hu_Ward);
        hu_ward Delete(int id);
        IEnumerable<hu_ward> GetAll();
        IEnumerable<hu_ward> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_ward GetById(int id);
        IEnumerable<hu_ward> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class hu_wardServices : Ihu_wardServices
    {
        Ihu_wardRepository _WardRepository;
        IUnitOfWork _unitOfWork;
        public hu_wardServices(hu_wardRepository hu_WardRepository, IUnitOfWork unitOfWork)
        {
            this._WardRepository = hu_WardRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_ward Add(hu_ward hu_Ward)
        {
            return _WardRepository.Add(hu_Ward);
        }

        public hu_ward Delete(int id)
        {
            return _WardRepository.Delete(id);
        }

        public IEnumerable<hu_ward> GetAll()
        {
            return _WardRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_ward> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _WardRepository.GetAllByWard(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_ward> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _WardRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_ward GetById(int id)
        {
            return _WardRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_ward hu_Ward)
        {
            _WardRepository.Update(hu_Ward);
        }
    }
}
