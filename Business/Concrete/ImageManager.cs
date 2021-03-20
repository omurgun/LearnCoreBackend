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
    public class ImageManager : IImageService
    {
        readonly IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public IResult Add(Image image)
        {
            _imageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Update(Image image)
        {
            _imageDal.Update(image);
            return new SuccessResult();
        }

        public IResult Delete(Image image)
        {
            _imageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<Image> GetById(int id)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(b => b.Id == id));
        }
    }
}
