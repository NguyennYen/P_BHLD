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
        hu_nation Add(hu_nation hu_Nation);
        void Update(hu_nation hu_Nation);
        hu_nation Delete(int id);
        IEnumerable<hu_nation> GetAll();
        IEnumerable<hu_nation> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_nation GetById(int id);
        IEnumerable<hu_nation> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_nationServices : Ihu_nationServices
    {
        Ihu_nationRepository _NationRepository;
        IUnitOfWork _unitOfWork;
        public hu_nationServices(hu_nationRepository hu_NationRepository, IUnitOfWork unitOfWork)
        {
            this._NationRepository = hu_NationRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_nation Add(hu_nation hu_Nation)
        {
            return _NationRepository.Add(hu_Nation);
        }

        public hu_nation Delete(int id)
        {
            return _NationRepository.Delete(id);
        }

        public IEnumerable<hu_nation> GetAll()
        {
            return _NationRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_nation> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _NationRepository.GetAllByDistrict(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_nation> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _NationRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_nation GetById(int id)
        {
            return _NationRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_nation hu_Nation)
        {
            _NationRepository.Update(hu_Nation);
        }
    }
}
