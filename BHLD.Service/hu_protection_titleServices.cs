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
    public interface Ihu_protection_titleServices
    {
        hu_protection_title Add(hu_protection_title hu_Protection_Title);
        void Update(hu_protection_title hu_Protection_Title);
        hu_protection_title Delete(int id);
        IEnumerable<hu_protection_title> GetAll();
        IEnumerable<hu_protection_title> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_protection_title GetById(int id);
        IEnumerable<hu_protection_title> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class hu_protection_titleServices : Ihu_protection_titleServices
    {
        Ihu_protection_titleRepository _Protection_TitleRepository;
        IUnitOfWork _unitOfWork;
        public hu_protection_titleServices(hu_protection_titleRepository hu_Protection_TitleRepository, IUnitOfWork unitOfWork)
        {
            this._Protection_TitleRepository = hu_Protection_TitleRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_protection_title Add(hu_protection_title hu_Protection_Title)
        {
            return _Protection_TitleRepository.Add(hu_Protection_Title);
        }

        public hu_protection_title Delete(int id)
        {
            return _Protection_TitleRepository.Delete(id);
        }

        public IEnumerable<hu_protection_title> GetAll()
        {
            return _Protection_TitleRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_protection_title> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Protection_TitleRepository.GetAllByProtectionTitle(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_protection_title> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Protection_TitleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_protection_title GetById(int id)
        {
            return _Protection_TitleRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_title hu_Protection_Title)
        {
            _Protection_TitleRepository.Update(hu_Protection_Title);
        }
    }
}
