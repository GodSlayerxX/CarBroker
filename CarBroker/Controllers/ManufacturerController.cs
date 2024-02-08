using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarBroker.BL.Interfaces;
using CarBroker.Models.User;

namespace CarBroker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet("GetManufacturerById")]
        public Manufacturer GetManufacturerById(int id)
        {
            return _manufacturerService.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<Manufacturer> GetAllManacturers()
        {
            return _manufacturerService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Manufacturer manufacturer)
        {
            _manufacturerService.Add(manufacturer);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _manufacturerService.Remove(id);
        }
    }
}
