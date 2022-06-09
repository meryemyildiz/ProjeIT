using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface SponsorService
    {
        List<Sponsor> GetList();
        void SponsorAdd(Sponsor sponsor);
        Sponsor GetById(int id);
        void SponsorDelete(Sponsor sponsor);
        void SponsorUpdate(Sponsor sponsor);
    }
}
