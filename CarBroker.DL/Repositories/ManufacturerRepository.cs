using CarBroker.DL.Interfaces;
using CarBroker.DL.MemoryDb;
using CarBroker.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBroker.DL.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        public List<Manufacturer> GetAll()
        {
            return InMemoryDb.ManufacturerInfo;
        }
        public Manufacturer GetById(int id)
        {
            return InMemoryDb.ManufacturerInfo.First(a => a.Id == id);
        }
        public void Add(Manufacturer manufacturer)
        {
            InMemoryDb.ManufacturerInfo.Add(manufacturer);
        }
        public void Remove(int id)
        {
            var manufacturer = GetById(id);
            InMemoryDb.ManufacturerInfo.Remove(manufacturer);
        }
    }
}
