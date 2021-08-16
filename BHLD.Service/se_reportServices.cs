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
        void Add(se_report post);
        void Update(se_report post);
        void Delete(int id);
        IEnumerable<se_report> GetAll();
        IEnumerable<se_report> GetAllPaging(int page, int pageSize, out int totalRow);
        se_report GetById(int id);
        IEnumerable<se_report> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_reportServices : Ise_reportServices
    {
        se_reportRepository _se_reportRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_report post)
        {
            _se_reportRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_reportRepository.Delete(id);
        }

        public IEnumerable<se_report> GetAll()
        {
            return _se_reportRepository.GetAll(new string[] { "Post_se_report" });
        }

        public IEnumerable<se_report> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _se_reportRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_report> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _se_reportRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_report GetById(int id)
        {
            return _se_reportRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_report post)
        {
            _se_reportRepository.Update(post);
        }
    }
}
