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
    public interface Iot_other_list_typeServices
    {
        void Add(ot_other_list_type post);
        void Update(ot_other_list_type post);
        void Delete(int id);
        IEnumerable<ot_other_list_type> GetAll();
        IEnumerable<ot_other_list_type> GetAllPaging(int page, int pageSize, out int totalRow);
        ot_other_list_type GetById(int id);
        IEnumerable<ot_other_list_type> GetAllByPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();


    }

    public class ot_other_list_typeServices : Iot_other_list_typeServices
    {
        ot_other_list_typeRepository _ot_other_list_typeRepository;
        IUnitOfWork _unitOfWork;
        public void Add(ot_other_list_type post)
        {
            _ot_other_list_typeRepository.Add(post);
        }

        public void Delete(int id)
        {
            _ot_other_list_typeRepository.Delete(id);
        }

        public IEnumerable<ot_other_list_type> GetAll()
        {
            return _ot_other_list_typeRepository.GetAll(new string[] { "Post_ot_other_list_type" });
        }

        public IEnumerable<ot_other_list_type> GetAllByPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _ot_other_list_typeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public IEnumerable<ot_other_list_type> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _ot_other_list_typeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);
        }

        public ot_other_list_type GetById(int id)
        {
            return _ot_other_list_typeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ot_other_list_type post)
        {
            _ot_other_list_typeRepository.Update(post);
        }
    }
}
