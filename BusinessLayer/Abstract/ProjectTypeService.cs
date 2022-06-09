using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ProjectTypeService
    {
        List<ProjectType> GetList();
        void ProjectTypeAdd(ProjectType projectType);
        ProjectType GetById(int id);
        void ProjectTypeDelete(ProjectType projectType);
        void ProjectTypeUpdate(ProjectType projectType);
    }
}
