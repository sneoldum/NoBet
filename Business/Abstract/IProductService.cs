﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetbyCategory(int categoryId);

        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}