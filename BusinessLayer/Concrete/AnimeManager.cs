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
    public class AnimeManager : IAnimeService
    {
        IAnimeDal _animeDal;

        public AnimeManager(IAnimeDal animeDal)
        {
            _animeDal = animeDal;
        }

        public List<Anime> GetList()
        {
            return _animeDal.GetListAll();
        }

        public void TAdd(Anime t)
        {
            _animeDal.Insert(t);
        }

        public void TDelete(Anime t)
        {
            _animeDal.Delete(t);
        }

        public Anime TGetById(int id)
        {
            return _animeDal.GetByID(id);
        }

        public void TUpdate(Anime t)
        {
            _animeDal.Update(t);
        }
    }
}
