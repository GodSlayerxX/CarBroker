using CarBroker.BL.Interfaces;
using CarBroker.DL.Interfaces;
using CarBroker.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.BL.Services
{
    public class CarService : Interfaces.ICarService
    {
        private readonly Interfaces.ICarService _carRepository;
        public CarService(DL.Interfaces.ICarRepository carRepository) 
        {
            _carRepository = (Interfaces.ICarService?)carRepository; 
        }

        public void Add(Car car)
        {
            _carRepository.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public Car GetById(int id)
        {
            if (id <= 0) return new Car();

            return _carRepository.GetById(id);
        }

        public void Remove(int id)
        {
            _carRepository.Remove(id);
        }

        public List<Car> GetAllCarsByManufacturerId(int manufacturerId)
        {
            return _carRepository.GetAllCarsByManufacturerId(manufacturerId);
        }
    }
}
