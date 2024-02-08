using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.Models.Request
{
    public class GetCarsByManufacturerRequest
    {
        public int ManufacturerId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set;}
    }
}
