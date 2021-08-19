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
    public interface Ihu_titleServices
    {
        hu_title Add(hu_title hu_Title);
        void Update(hu_title hu_Title);
        hu_title Delete(int id);
        IEnumerable<hu_title> GetAll();
        IEnumerable<hu_title> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_title GetById(int id);
        IEnumerable<hu_title> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_titleServices : Ihu_titleServices
    {
        Ihu_titleRepository _TitleRepository;
        IUnitOfWork _unitOfWork;
        public hu_titleServices(hu_titleRepository hu_TitleRepository, IUnitOfWork unitOfWork)
        {
            this._TitleRepository = hu_TitleRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_title Add(hu_title hu_Title)
        {
            return _TitleRepository.Add(hu_Title);
        }

        public hu_title Delete(int id)
        {
            return _TitleRepository.Delete(id);
        }

        public IEnumerable<hu_title> GetAll()
        {
            return _TitleRepository.GetAll(new string[] { "Title" });
        }



        public IEnumerable<hu_title> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _TitleRepository.GetAllByTitle(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_title> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _TitleRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }

        public hu_title GetById(int id)
        {
            return _TitleRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_title hu_Title)
        {
            _TitleRepository.Update(hu_Title);
        }
    }
}
