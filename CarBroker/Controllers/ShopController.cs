using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarBroker.BL.Interfaces;
using CarBroker.BL.Services;
using CarBroker.Models.Request;
using CarBroker.Models.Response;
using CarBroker.Models.User;
using CarBroker.Validators;

namespace CarBroker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpPost("GetCarsByManufacturer")]
        public GetCarsByManufacturerResponse? GetCarsByManufacturer(GetCarsByManufacturerRequest request)
        {
            if (request == null) return null;

            return _shopService.GetCarsByManufacturer(request);

        }

        [HttpPost("TestEndpoint")]
        public string GetTestEndpoint([FromBody] GetCarsByManufacturerRequest request)
        {
            var validator = new GetCarsByManufacturerRequestValidator();
            var result = validator.Validate(request);
            if (result.IsValid)
            {
                return "Test passed";
            }
            return "Test failed";
        }
    }
}
