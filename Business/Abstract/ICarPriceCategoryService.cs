using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarPriceCategoryService
    {
        IDataResult<List<CarPriceCategory>> GetAll();
        IResult Add(CarPriceCategory carPriceCategory);
        IResult Update(CarPriceCategory carPriceCategory);
        IResult Delete(CarPriceCategory carPriceCategory);
        IDataResult<CarPriceCategory> GetById(int id);

    }
}
