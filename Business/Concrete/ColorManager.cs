using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color car)
        {
            _colorDal.Add(car);
        }

        public void Delete(Color car)
        {
            _colorDal.Delete(car);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c=> c.ColorId == id);
        }

        public void Update(Color car)
        {
            _colorDal.Update(car);
        }
    }
}
