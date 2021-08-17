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
    public interface Iot_other_listServices
    {
        void Add(ot_other_list post);
        void Update(ot_other_list post);
        void Delete(int id);
        IEnumerable<ot_other_list> GetAll();
        IEnumerable<ot_other_list> GetAllPaging(int page, int pageSize, out int totalRow);
        ot_other_list GetById(int id);
        IEnumerable<ot_other_list> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class ot_other_listServices : Iot_other_listServices
    {
        ot_other_listRepository _ot_other_listRepository;
        IUnitOfWork _unitOfWork;
        public void Add(ot_other_list post)
        {
            _ot_other_listRepository.Add(post);
        }

        public void Delete(int id)
        {
            _ot_other_listRepository.Delete(id);
        }

        public IEnumerable<ot_other_list> GetAll()
        {
            return _ot_other_listRepository.GetAll(new string[] { "Post_ot_other_list" });
        }

        public IEnumerable<ot_other_list> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _ot_other_listRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<ot_other_list> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _ot_other_listRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public ot_other_list GetById(int id)
        {
            return _ot_other_listRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ot_other_list post)
        {
            _ot_other_listRepository.Update(post);
        }
    }
}
