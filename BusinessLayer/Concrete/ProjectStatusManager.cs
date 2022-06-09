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
    public class ProjectStatusManager : ProjectStatusService
    {
        IProjectStatusDal _projectStatusDal;

        public ProjectStatusManager(IProjectStatusDal projectStatusDal)
        {
            _projectStatusDal = projectStatusDal;
        }

        public ProjectStatus GetById(int id)
        {
            return _projectStatusDal.Get(x => x.StatusId == id);
        }

        public List<ProjectStatus> GetList()
        {
            return _projectStatusDal.List();
        }

        public void ProjectStatuseAdd(ProjectStatus projectStatus)
        {
            _projectStatusDal.Insert(projectStatus);
        }

        public void ProjectStatuseDelete(ProjectStatus projectStatus)
        {
            _projectStatusDal.Update(projectStatus);
        }

        public void ProjectStatusUpdate(ProjectStatus projectStatus)
        {
            _projectStatusDal.Update(projectStatus);
        }
    }
}
