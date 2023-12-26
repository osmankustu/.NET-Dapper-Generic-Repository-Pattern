using Bussines.Abstract;
using Core.Aspects.Autofact.Performance;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void add(Products products)
        {
            _productDal.add(products);
        }

        public void delete(Products products)
        {
            _productDal.delete(products);
        }
        [PerformanceAspect(1)]
        public Products Get(int id)
        {
           return _productDal.Get(id);
        }

        [PerformanceAspect(1)]
        public List<Products> GetAll()
        {
            return _productDal.getAll();
        }

        public void update(Products products)
        {
            _productDal.update(products);
        }
    }
}
