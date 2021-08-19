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
        hu_org_title Add(hu_org_title hu_Employee);
        void Update(hu_org_title hu_Employee);
        hu_org_title Delete(int id);
        IEnumerable<hu_org_title> GetAll();
        IEnumerable<hu_org_title> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_org_title GetById(int id);
        IEnumerable<hu_org_title> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_org_titleServices : Ihu_org_titleServices
    {
        Ihu_org_titleRepository _Org_TitleRepository;
        IUnitOfWork _unitOfWork;
        public hu_org_titleServices(hu_org_titleRepository hu_Org_TitleRepository, IUnitOfWork unitOfWork)
        {
            this._Org_TitleRepository = hu_Org_TitleRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_org_title Add(hu_org_title hu_Title)
        {
            return _Org_TitleRepository.Add(hu_Title);
        }

        public hu_org_title Delete(int id)
        {
            return _Org_TitleRepository.Delete(id);
        }

        public IEnumerable<hu_org_title> GetAll()
        {
            return _Org_TitleRepository.GetAll(new string[] { "Org_title" });
        }



        public IEnumerable<hu_org_title> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Org_TitleRepository.GetAllByOrgTitle(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_org_title> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Org_TitleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_org_title GetById(int id)
        {
            return _Org_TitleRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_org_title hu_District)
        {
            _Org_TitleRepository.Update(hu_District);
        }
    }
}
