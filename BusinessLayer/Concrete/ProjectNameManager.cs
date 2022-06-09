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
    public class ProjectNameManager : ProjectNameService
    {
        IProjectNameDal _projectNameDal;

        public ProjectNameManager(IProjectNameDal projectNameDal)
        {
            _projectNameDal = projectNameDal;
        }

        public ProjectName GetById(int id)
        {
            return _projectNameDal.Get(x => x.NameId == id);
        }

        public List<ProjectName> GetList()
        {
            return _projectNameDal.List();
        }

        public void ProjectNameAdd(ProjectName projectName)
        {
            _projectNameDal.Insert(projectName);
        }

        public void ProjectNameDelete(ProjectName projectName)
        {
            _projectNameDal.Delete(projectName);
        }

        public void ProjectNameUpdate(ProjectName projectName)
        {
            _projectNameDal.Update(projectName);
        }
    }
}
