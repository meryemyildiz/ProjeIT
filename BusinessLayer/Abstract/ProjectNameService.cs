using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ProjectNameService
    {
        List<ProjectName> GetList();
        void ProjectNameAdd(ProjectName projectName);
        ProjectName GetById(int id);
        void ProjectNameDelete(ProjectName projectName);
        void ProjectNameUpdate(ProjectName projectName);
    }
}
