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
    public interface Ise_user_reportServices
    {
        se_user_report Add(se_user_report se_User_Report);
        void Update(se_user_report se_User_Report);
        se_user_report Delete(int id);
        IEnumerable<se_user_report> GetAll();
        IEnumerable<se_user_report> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_user_report GetById(int id);
        IEnumerable<se_user_report> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class se_user_reportServices : Ise_user_reportServices
    {
        Ise_user_reportRepository _User_ReportRepository;
        IUnitOfWork _unitOfWork;
        public se_user_reportServices(se_user_reportRepository se_User_ReportRepository, IUnitOfWork unitOfWork)
        {
            this._User_ReportRepository = se_User_ReportRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_user_report Add(se_user_report se_User_Report)
        {
            return _User_ReportRepository.Add(se_User_Report);
        }

        public se_user_report Delete(int id)
        {
            return _User_ReportRepository.Delete(id);
        }

        public IEnumerable<se_user_report> GetAll()
        {
            return _User_ReportRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_user_report> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _User_ReportRepository.GetAllByUserReport(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_user_report> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _User_ReportRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_user_report GetById(int id)
        {
            return _User_ReportRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user_report se_User_Report)
        {
            _User_ReportRepository.Update(se_User_Report);
        }
    }
}
