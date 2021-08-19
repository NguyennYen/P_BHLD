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
        hu_shoes_setting Add(hu_shoes_setting hu_Shoes_Setting);
        void Update(hu_shoes_setting hu_Shoes_Setting);
        hu_shoes_setting Delete(int id);
        IEnumerable<hu_shoes_setting> GetAll();
        IEnumerable<hu_shoes_setting> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_shoes_setting GetById(int id);
        IEnumerable<hu_shoes_setting> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class hu_shoes_settingServices : Ihu_shoes_settingServices
    {
        Ihu_shoes_settingRepository _Shoes_SettingRepository;
        IUnitOfWork _unitOfWork;
        public hu_shoes_settingServices(hu_shoes_settingRepository hu_Shoes_SettingRepository, IUnitOfWork unitOfWork)
        {
            this._Shoes_SettingRepository = hu_Shoes_SettingRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_shoes_setting Add(hu_shoes_setting hu_Shoes_Setting)
        {
            return _Shoes_SettingRepository.Add(hu_Shoes_Setting);
        }

        public hu_shoes_setting Delete(int id)
        {
            return _Shoes_SettingRepository.Delete(id);
        }

        public IEnumerable<hu_shoes_setting> GetAll()
        {
            return _Shoes_SettingRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_shoes_setting> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Shoes_SettingRepository.GetAllByShoesSetting(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_shoes_setting> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Shoes_SettingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_shoes_setting GetById(int id)
        {
            return _Shoes_SettingRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
        public void Update(hu_shoes_setting hu_Shoes_Setting)
        {
            _Shoes_SettingRepository.Update(hu_Shoes_Setting);
        }
    }
}
