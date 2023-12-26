using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IProductService
    {
        void add(Products products);
        void update(Products products);
        void delete(Products products);
        List<Products> GetAll();
        Products Get(int id);
    }
}
