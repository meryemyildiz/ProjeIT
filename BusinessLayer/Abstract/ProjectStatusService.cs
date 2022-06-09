using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ProjectStatusService
    {
        List<ProjectStatus> GetList();
        void ProjectStatuseAdd(ProjectStatus projectStatus);
        ProjectStatus GetById(int id);
        void ProjectStatuseDelete(ProjectStatus projectStatus);
        void ProjectStatusUpdate(ProjectStatus projectStatus);
    }
}
