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
    public class SponsorManager : SponsorService
    {
        ISponsorDal _sponsorDal;

        public SponsorManager(ISponsorDal sponsorDal)
        {
            _sponsorDal = sponsorDal;
        }

        public Sponsor GetById(int id)
        {
            return _sponsorDal.Get(x => x.SponsorId == id);
        }

        public List<Sponsor> GetList()
        {
            return _sponsorDal.List();
        }

        public void SponsorAdd(Sponsor sponsor)
        {
            _sponsorDal.Insert(sponsor);
        }

        public void SponsorDelete(Sponsor sponsor)
        {
            _sponsorDal.Update(sponsor);
        }

        public void SponsorUpdate(Sponsor sponsor)
        {
            _sponsorDal.Update(sponsor);
        }
    }
}
