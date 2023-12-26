using Core.GenericDataAccessRepository.Concrete.DapperFramework;
using Core.GenericDataAccessRepository.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDal : DapperEntityRepositoryBase<Products>,IProductDal
    {
    }
}
