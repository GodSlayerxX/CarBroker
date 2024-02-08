using CarBroker.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.BL.Interfaces
{
    public interface IManufacturerService
    {
        List<Manufacturer> GetAll();

        Manufacturer GetById(int id);

        void Add(Manufacturer manufacturer);

        void Remove(int id);
    }
}
