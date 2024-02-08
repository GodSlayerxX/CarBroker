using CarBroker.BL.Interfaces;
using CarBroker.Models.Request;
using CarBroker.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarBroker.BL.Services.ShopService;

namespace CarBroker.BL.Services
{
 
        public class ShopService : IShopService
        {
            private readonly IManufacturerService _manufacturerService;
            private readonly ICarService _carService;

            public ShopService(IManufacturerService manufacturerService, ICarService carService)
            {
                _manufacturerService = manufacturerService;
                _carService = carService;
            }

            public GetCarsByManufacturerResponse? GetCarsByManufacturer(GetCarsByManufacturerRequest request)
            {
                var response = new GetCarsByManufacturerResponse
                {
                    Manufacturer = _manufacturerService.GetById(request.ManufacturerId),
                    Cars = _carService.GetAllCarsByManufacturerId(request.ManufacturerId)
                };
                return response;
            }
        };
    }

