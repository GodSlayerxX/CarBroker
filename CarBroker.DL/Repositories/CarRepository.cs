using CarBroker.DL.Interfaces;
using CarBroker.DL.MemoryDb;
using CarBroker.Models.User;

namespace CarBroker.DL.Repositories
{
    public class CarRepository : ICarRepository
    {

        public List<Car> GetAll()
        {
            return InMemoryDb.CarDetails;
        }
        public Car GetById(int id)
        {
            return InMemoryDb.CarDetails.First(a => a.Id == id);
        }
        public void Add(Car car)
        {
            InMemoryDb.CarDetails.Add(car);
        }
        public void Remove(int id)
        {
            var car = GetById(id);
            InMemoryDb.CarDetails.Remove(car);
        }
        public List<Car> GetAllCarsByManufacturerId(int id)
        {
            var result = InMemoryDb.CarDetails.Where(b => b.ManufacturerId == id).ToList();
            return result;
        }
    }
}
