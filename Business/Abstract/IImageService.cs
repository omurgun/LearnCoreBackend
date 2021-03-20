using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IResult Add(Image image);
        IResult Update(Image image);
        IResult Delete(Image image);
        IDataResult<Image> GetById(int id);
    }
}
