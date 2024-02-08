using CarBroker.Models.Request;
using CarBroker.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.BL.Interfaces
{
    public interface IShopService
    {
        GetCarsByManufacturerResponse? GetCarsByManufacturer(GetCarsByManufacturerRequest request);
    }
}
