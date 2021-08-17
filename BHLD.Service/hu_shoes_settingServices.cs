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
    public interface Ihu_shoes_settingServices
    {
        void Add(hu_shoes_setting post);
        void Update(hu_shoes_setting post);
        void Delete(int id);
        IEnumerable<hu_shoes_setting> GetAll();
        IEnumerable<hu_shoes_setting> GetAllPaging(int page, int pageSize, out int totalRow);
        hu_shoes_setting GetById(int id);
        IEnumerable<hu_shoes_setting> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_shoes_settingServices : Ihu_shoes_settingServices
    {
        hu_shoes_settingRepository _hu_shoes_settingRepository;
        IUnitOfWork _unitOfWork;
        public void Add(hu_shoes_setting post)
        {
            _hu_shoes_settingRepository.Add(post);
        }

        public void Delete(int id)
        {
            _hu_shoes_settingRepository.Delete(id);
        }

        public IEnumerable<hu_shoes_setting> GetAll()
        {
            return _hu_shoes_settingRepository.GetAll(new string[] { "Post_hu_shoes_setting" });
        }

        public IEnumerable<hu_shoes_setting> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _hu_shoes_settingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<hu_shoes_setting> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_shoes_settingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public hu_shoes_setting GetById(int id)
        {
            return _hu_shoes_settingRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_shoes_setting post)
        {
            _hu_shoes_settingRepository.Update(post);
        }
    }
}
