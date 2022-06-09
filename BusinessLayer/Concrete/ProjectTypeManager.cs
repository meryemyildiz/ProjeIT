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
    public class ProjectTypeManager : ProjectTypeService
    {
        IProjectTypeDal _projectTypeDal;

        public ProjectTypeManager(IProjectTypeDal projectTypeDal)
        {
            _projectTypeDal = projectTypeDal;
        }

        public ProjectType GetById(int id)
        {
          return  _projectTypeDal.Get(x => x.ProjectTypeId == id);
        }

        public List<ProjectType> GetList()
        {
            return _projectTypeDal.List();
        }

        public void ProjectTypeAdd(ProjectType projectType)
        {
            _projectTypeDal.Insert(projectType);
        }

        public void ProjectTypeDelete(ProjectType projectType)
        {
            _projectTypeDal.Update(projectType);
        }

        public void ProjectTypeUpdate(ProjectType projectType)
        {
            _projectTypeDal.Update(projectType);
        }
    }
}
