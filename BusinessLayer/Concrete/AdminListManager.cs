using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminListManager : AdminListService
    {
        IAdminListDal _adminListDal;

        public AdminListManager(IAdminListDal adminListDal)
        {
            _adminListDal = adminListDal;
        }

        public void AdminListAdd(AdminList adminList)
        {
            _adminListDal.Insert(adminList);
        }

        public void AdminListDelete(AdminList adminList)
        {
            _adminListDal.Delete(adminList);
        }

        public void AdminListUpdate(AdminList adminList)
        {
            _adminListDal.Update(adminList);
        }

        public AdminList GetById(int id)
        {
            return _adminListDal.Get(x => x.Id == id);
        }

        public List<AdminList> GetList()
        {
            return _adminListDal.List();
        }
    }
}
