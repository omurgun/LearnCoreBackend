using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarPriceCategoryManager:ICarPriceCategoryService
    {
        readonly ICarPriceCategoryDal _carPriceCategoryDal;

        public CarPriceCategoryManager(ICarPriceCategoryDal carPriceCategoryDal)
        {
            _carPriceCategoryDal = carPriceCategoryDal;
        }

        public IDataResult<List<CarPriceCategory>> GetAll()
        {
            return new SuccessDataResult<List<CarPriceCategory>>(_carPriceCategoryDal.GetAll());
        }

        public IResult Add(CarPriceCategory carPriceCategory)
        {
            _carPriceCategoryDal.Add(carPriceCategory);
            return new SuccessResult();
        }

        public IResult Update(CarPriceCategory carPriceCategory)
        {
            _carPriceCategoryDal.Update(carPriceCategory);
            return new SuccessResult();
        }

        public IResult Delete(CarPriceCategory carPriceCategory)
        {
            _carPriceCategoryDal.Delete(carPriceCategory);
            return new SuccessResult();
        }

        public IDataResult<CarPriceCategory> GetById(int id)
        {
            return new SuccessDataResult<CarPriceCategory>(_carPriceCategoryDal.Get(b => b.Id == id));
        }
    }
}
