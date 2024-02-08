using CarBroker.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.Models.Response
{
    public class GetCarsByManufacturerResponse
    {
            public Manufacturer? Manufacturer { get; set; }
            public List<Car>? Cars { get; set; }
     }
}

