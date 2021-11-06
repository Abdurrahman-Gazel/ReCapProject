using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand car)
        {
            _brandDal.Add(car);
        }

        public void Delete(Brand car)
        {
            _brandDal.Delete(car);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b=>b.BrandId == id);
        }

        public void Update(Brand car)
        {
            _brandDal.Update(car);
        }
    }
}
