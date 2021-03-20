using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CarPriceCategory : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int PriceCategoryId { get; set; }
        public int Price { get; set; }
    }
}
