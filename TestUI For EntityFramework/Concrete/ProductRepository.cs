
using Core.GenericDataAccessRepository.Concrete.EntityFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUI.Abstract;

namespace TestUI.Concrete
{
    public class ProductRepository : EfEntityRepositoryBase<Products,EfContext>,IProductService
    {
    }
}
