using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class ProjectStatusDal : GenericRepositoryDal<ProjectStatus>, IProjectStatusDal
    {
    }
}
