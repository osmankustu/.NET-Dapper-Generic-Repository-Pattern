using Core.GenericDataAccessRepository.Abstract;
using Core.GenericDataAccessRepository.Concrete.DapperFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUI.Abstract
{
    public interface IProductService : IEntitiyRepository<Products>
    {
    }
}
