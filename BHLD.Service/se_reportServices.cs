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
    public interface Ise_reportServices
    {
        se_report Add(se_report se_Report);
        void Update(se_report se_Report);
        se_report Delete(int id);
        IEnumerable<se_report> GetAll();
        IEnumerable<se_report> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        se_report GetById(int id);
        IEnumerable<se_report> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class se_reportServices : Ise_reportServices
    {
        Ise_reportRepository _ReportRepository;
        IUnitOfWork _unitOfWork;
        public se_reportServices(se_reportRepository se_ReportRepository, IUnitOfWork unitOfWork)
        {
            this._ReportRepository = se_ReportRepository;
            this._unitOfWork = unitOfWork;
        }

        public se_report Add(se_report se_Report)
        {
            return _ReportRepository.Add(se_Report);
        }

        public se_report Delete(int id)
        {
            return _ReportRepository.Delete(id);
        }

        public IEnumerable<se_report> GetAll()
        {
            return _ReportRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<se_report> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _ReportRepository.GetAllByReport(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<se_report> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _ReportRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public se_report GetById(int id)
        {
            return _ReportRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_report se_Report)
        {
            _ReportRepository.Update(se_Report);
        }
    }
}
