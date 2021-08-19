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
        ot_other_list_type Add(ot_other_list_type other_List_Type);
        void Update(ot_other_list_type other_List_Type);
        ot_other_list_type Delete(int id);
        IEnumerable<ot_other_list_type> GetAll();
        IEnumerable<ot_other_list_type> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        ot_other_list_type GetById(int id);
        IEnumerable<ot_other_list_type> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

        public class ot_other_list_typeServices : Iot_other_list_typeServices
    {
        Iot_other_list_typeRepository _Other_List_TypeRepository;
        IUnitOfWork _unitOfWork;
        public ot_other_list_typeServices(Iot_other_list_typeRepository other_List_TypeRepository, IUnitOfWork unitOfWork)
        {
            this._Other_List_TypeRepository = other_List_TypeRepository;
            this._unitOfWork = unitOfWork;
        }

        public ot_other_list_type Add(ot_other_list_type other_List_Type)
        {
            return _Other_List_TypeRepository.Add(other_List_Type);
        }

        public ot_other_list_type Delete(int id)
        {
            return _Other_List_TypeRepository.Delete(id);
        }

        public IEnumerable<ot_other_list_type> GetAll()
        {
            return _Other_List_TypeRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<ot_other_list_type> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Other_List_TypeRepository.GetAllByListType(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<ot_other_list_type> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Other_List_TypeRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public ot_other_list_type GetById(int id)
        {
            return _Other_List_TypeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ot_other_list_type other_List_Type)
        {
            _Other_List_TypeRepository.Update(other_List_Type);
        }
    }
}
