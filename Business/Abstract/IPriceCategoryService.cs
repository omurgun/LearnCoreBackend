using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPriceCategoryService
    {
        IDataResult<List<PriceCategory>> GetAll();
        IResult Add(PriceCategory priceCategory);
        IResult Update(PriceCategory priceCategory);
        IResult Delete(PriceCategory priceCategory);
        IDataResult<PriceCategory> GetById(int id);
    }
}
