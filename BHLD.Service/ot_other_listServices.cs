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
        ot_other_list Add(ot_other_list ot_Other_List);
        void Update(ot_other_list ot_Other_List);
        ot_other_list Delete(int id);
        IEnumerable<ot_other_list> GetAll();
        IEnumerable<ot_other_list> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        ot_other_list GetById(int id);
        IEnumerable<ot_other_list> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();
    }

    public class ot_other_listServices : Iot_other_listServices
    {
        Iot_other_listRepository _Other_ListRepository;
        IUnitOfWork _unitOfWork;
        public ot_other_listServices(ot_other_listRepository other_ListRepository, IUnitOfWork unitOfWork)
        {
            this._Other_ListRepository = other_ListRepository;
            this._unitOfWork = unitOfWork;
        }

        public ot_other_list Add(ot_other_list ot_Other_List)
        {
            return _Other_ListRepository.Add(ot_Other_List);
        }

        public ot_other_list Delete(int id)
        {
            return _Other_ListRepository.Delete(id);
        }

        public IEnumerable<ot_other_list> GetAll()
        {
            return _Other_ListRepository.GetAll(new string[] { "D" });
        }



        public IEnumerable<ot_other_list> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _Other_ListRepository.GetAllByList(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<ot_other_list> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _Other_ListRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public ot_other_list GetById(int id)
        {
            return _Other_ListRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ot_other_list ot_Other_List)
        {
            _Other_ListRepository.Update(ot_Other_List);
        }
    }
}
