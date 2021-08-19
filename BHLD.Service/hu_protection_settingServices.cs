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
    public interface Ihu_protection_settingServices
    {
        hu_protection_setting Add(hu_protection_setting hu_Protection_Setting);
        void Update(hu_protection_setting hu_Protection_Setting);
        hu_protection_setting Delete(int id);
        IEnumerable<hu_protection_setting> GetAll();
        IEnumerable<hu_protection_setting> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_protection_setting GetById(int id);
        IEnumerable<hu_protection_setting> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_settingServices : Ihu_protection_settingServices
    {
        Ihu_protection_settingRepository _Protection_SettingRepository;
        IUnitOfWork _unitOfWork;
        public hu_protection_settingServices(hu_protection_settingRepository hu_Protection_SettingRepository, IUnitOfWork unitOfWork)
        {
            this._Protection_SettingRepository = hu_Protection_SettingRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_protection_setting Add(hu_protection_setting hu_Protection_Setting)
        {
            return _Protection_SettingRepository.Add(hu_Protection_Setting);
        }

        public hu_protection_setting Delete(int id)
        {
            return _Protection_SettingRepository.Delete(id);
        }

        public IEnumerable<hu_protection_setting> GetAll()
        {
            return _Protection_SettingRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_protection_setting> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Protection_SettingRepository.GetAllByProtectionSet(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_protection_setting> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Protection_SettingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_protection_setting GetById(int id)
        {
            return _Protection_SettingRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_setting hu_Protection_Setting)
        {
            _Protection_SettingRepository.Update(hu_Protection_Setting);
        }
    }
}
