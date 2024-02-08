using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarBroker.BL.Interfaces;
using CarBroker.BL.Services;
using CarBroker.Models.User;
using CarBroker.DL.Interfaces;

namespace CarBroker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("GetCarById")]
        public Car GetCarById(int id)
        {
            return _carRepository.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Car car)
        {
            if (car == null) return;
            _carRepository.Add(car);

        }

        [HttpDelete]
        public void Delete(int id)
        {
            _carRepository.Remove(id);
        }
    }
}
