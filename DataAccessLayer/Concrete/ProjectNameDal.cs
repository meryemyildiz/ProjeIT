using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class ProjectNameDal : GenericRepositoryDal<ProjectName>, IProjectNameDal
    {
    }
}
