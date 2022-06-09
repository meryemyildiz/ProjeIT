using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface AdminListService
    {
        List<AdminList> GetList();
        void AdminListAdd(AdminList adminList);
        AdminList GetById(int id);
        void AdminListDelete(AdminList adminList);
        void AdminListUpdate(AdminList adminList);
    }
}
