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
        hu_protection_title_setting Add(hu_protection_title_setting hu_Protection_Title_Setting);
        void Update(hu_protection_title_setting hu_Protection_Title_Settinghu_Protection_Title_Setting);
        hu_protection_title_setting Delete(int id);
        IEnumerable<hu_protection_title_setting> GetAll();
        IEnumerable<hu_protection_title_setting> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_protection_title_setting GetById(int id);
        IEnumerable<hu_protection_title_setting> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class hu_protection_title_settingServices : Ihu_protection_title_settingServices
    {
        Ihu_protection_title_settingRepository _Protection_Title_SettingRepository;
        IUnitOfWork _unitOfWork;
        public hu_protection_title_settingServices(hu_protection_title_settingRepository hu_Protection_Title_SettingRepository, IUnitOfWork unitOfWork)
        {
            this._Protection_Title_SettingRepository = hu_Protection_Title_SettingRepository;
            this._unitOfWork = unitOfWork;
        }

        public hu_protection_title_setting Add(hu_protection_title_setting hu_Protection_Title_Setting)
        {
            return _Protection_Title_SettingRepository.Add(hu_Protection_Title_Setting);
        }

        public hu_protection_title_setting Delete(int id)
        {
            return _Protection_Title_SettingRepository.Delete(id);
        }

        public IEnumerable<hu_protection_title_setting> GetAll()
        {
            return _Protection_Title_SettingRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<hu_protection_title_setting> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Protection_Title_SettingRepository.GetAllByProtectionTitle(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_protection_title_setting> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Protection_Title_SettingRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_protection_title_setting GetById(int id)
        {
            return _Protection_Title_SettingRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_protection_title_setting hu_Protection_Title_Setting)
        {
            _Protection_Title_SettingRepository.Update(hu_Protection_Title_Setting);
        }
    }
}
