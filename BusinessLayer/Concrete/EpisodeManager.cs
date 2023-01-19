using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EpisodeManager : IEpisodeService
    {
        IEpisodeDal episodeDal;

        public EpisodeManager(IEpisodeDal episodeDal)
        {
            this.episodeDal = episodeDal;
        }

        public List<Episode> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Episode t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Episode t)
        {
            throw new NotImplementedException();
        }

        public Episode TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Episode t)
        {
            throw new NotImplementedException();
        }
    }
}
