﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int id);
        void Add(Brand car);
        void Update(Brand car);
        void Delete(Brand car);
    }
}
