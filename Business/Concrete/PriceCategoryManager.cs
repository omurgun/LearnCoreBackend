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
    public class PriceCategoryManager : IPriceCategoryService
    {
        readonly IPriceCategoryDal _priceCategoryDal;

        public PriceCategoryManager(IPriceCategoryDal priceCategoryDal)
        {
            _priceCategoryDal = priceCategoryDal;
        }

        public IDataResult<List<PriceCategory>> GetAll()
        {
            return new SuccessDataResult<List<PriceCategory>>(_priceCategoryDal.GetAll());
        }

        public IResult Add(PriceCategory priceCategory)
        {
            _priceCategoryDal.Add(priceCategory);
            return new SuccessResult();
        }

        public IResult Update(PriceCategory priceCategory)
        {
            _priceCategoryDal.Update(priceCategory);
            return new SuccessResult();
        }

        public IResult Delete(PriceCategory priceCategory)
        {
            _priceCategoryDal.Delete(priceCategory);
            return new SuccessResult();
        }

        public IDataResult<PriceCategory> GetById(int id)
        {
            return new SuccessDataResult<PriceCategory>(_priceCategoryDal.Get(b => b.Id == id));
        }
    }
}
