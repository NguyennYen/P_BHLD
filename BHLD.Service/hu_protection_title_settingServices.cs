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
    
    public interface Ihu_protection_title_settingServices
    {
        void Add(hu_protection_title_setting post);
        void Update(hu_protection_title_setting post);
        void Delete(int id);
        IEnumerable<hu_protection_title_setting> GetAll();
        IEnumerable<hu_protection_title_setting> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_protection_title_setting GetById(int id);
        IEnumerable<hu_protection_title_setting> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_title_settingServices : Ihu_protection_title_settingServices
    {
        hu_protection_title_settingRepository _hu_protection_title_settingRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_protection_title_setting post)
        {
            _hu_protection_title_settingRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_protection_title_settingRepository.Delete(id);
        }

        public IEnumerable<hu_protection_title_setting> GetAll()
        {
            return _hu_protection_title_settingRepository.GetAll(new string[] { "Post_hu_protection_title_setting" });
        }

        public IEnumerable<hu_protection_title_setting> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_protection_title_settingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_protection_title_setting> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_protection_title_settingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_protection_title_setting GetById(int id)
        {
            return _hu_protection_title_settingRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_title_setting post)
        {
            _hu_protection_title_settingRepository.Update(post);
        }
    }
}
