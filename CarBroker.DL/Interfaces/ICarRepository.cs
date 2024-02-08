using CarBroker.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.DL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();

        Car GetById(int id);

        void Add(Car car);

        void Remove(int id);

        List<Car> GetAllCarsByManufacturerId(int authorId);
    }
}
