using CarBroker.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarBroker.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Car> CarDetails = new List<Car>() { 
        new Car()
        {
            Id = 1,
            Name = "Toyota",
            Price = 30000,
            ManufacturerId = 1,
        },
        new Car()
        {
            Id = 2,
            Name = "Ford", 
            Price = 45000,
            ManufacturerId = 2,
        },
        new Car()
        {
            Id = 3,
            Name = "Mercedes-Benz",
            Price = 60000,
            ManufacturerId = 3,
        }
    };

    public static List<Manufacturer> ManufacturerInfo = new List<Manufacturer>()
        {
        new Manufacturer()
        {
            Id = 1,
            Name = "Toyota Motor Corp",
            Country = "Japan"
        },
        new Manufacturer()
        {
            Id= 2,
            Name = "Ford Motor Company.",
            Country = "USA"
        },
        new Manufacturer()
        {
            Id = 3,
            Name = "The Mercedes-Benz Group AG",
            Country = "Germany"
        },
        };
}
}
