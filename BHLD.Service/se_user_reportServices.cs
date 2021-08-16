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
        void Add(se_user_report post);
        void Update(se_user_report post);
        void Delete(int id);
        IEnumerable<se_user_report> GetAll();
        IEnumerable<se_user_report> GetAllPaging(int page, int pageSize, out int totalRow);
        se_user_report GetById(int id);
        IEnumerable<se_user_report> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class se_user_reportServices : Ise_user_reportServices
    {
        se_user_reportRepository _se_user_reportRepository;
        IUnitOfWork _unitOfWork;
        public void Add(se_user_report post)
        {
            _se_user_reportRepository.Add(post);
        }

        public void Delete(int id)
        {
            _se_user_reportRepository.Delete(id);
        }

        public IEnumerable<se_user_report> GetAll()
        {
            return _se_user_reportRepository.GetAll(new string[] { "Post_se_user_report" });
        }

        public IEnumerable<se_user_report> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _se_user_reportRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<se_user_report> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _se_user_reportRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public se_user_report GetById(int id)
        {
            return _se_user_reportRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(se_user_report post)
        {
            _se_user_reportRepository.Update(post);
        }
    }
}
