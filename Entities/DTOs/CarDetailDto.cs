using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.DTOs
{
   public class CarDetailDto :IDto
   {
       public int CarId { get; set; }
       public string BrandName { get; set; }
       public string ColorName { get; set; }
       public string ModelYear { get; set; }
       public int DailyPrice { get; set; }
       public int MonthlyPrice { get; set; }
       public int YearlyPrice { get; set; }
       public List<CarImage> CarImages { get; set; }
   }
}
