﻿using StoreApp.Data.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Abstract
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Category> Categories { get; }
        void CreateProduct(Product entity);
        int GetProductCount(string category);
        IEnumerable<Product> GetProductByCategory(string category, int sayfa, int sayfaSayisi);
    }

}
