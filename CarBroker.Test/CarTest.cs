using CarBroker.Models.User;
using CarBroker.DL.MemoryDb;
using CarBroker.DL.Interfaces;
using CarBroker.BL.Services;
using Moq;

namespace CarBroker.Test
{
    public class CarTest
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
        [Fact]
        public void GetAllByManufacturerId_Count_Check()
        {
            var expectedCount = 1;
            var manufacturerId = 2;

            var mockedCarRepository = new Mock<ICarRepository>();
            mockedCarRepository.Setup(x => x.GetAllCarsByManufacturerId(manufacturerId))
                .Returns(CarDetails.Where(p => p.ManufacturerId == manufacturerId).ToList());

            var service = new CarService(mockedCarRepository.Object);

            var result = service.GetAllCarsByManufacturerId(manufacturerId);

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void GetAllByManufacturerId_WrongId()
        {
            var expectedCount = 0;
            var manufacturerId = 4;

            var mockedCarRepository = new Mock<ICarRepository>();
            mockedCarRepository.Setup(x => x.GetAllCarsByManufacturerId(manufacturerId))
                .Returns(CarDetails.Where(p => p.ManufacturerId == manufacturerId).ToList());

            var service = new CarService(mockedCarRepository.Object);

            var result = service.GetAllCarsByManufacturerId(manufacturerId);

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void Remove_Count_Check()
        {
            var expectedResult = 2;
            var carId = 1;
            var carToRemove = CarDetails.FirstOrDefault(x => x.Id == carId);

            var mockedCarRepository = new Mock<ICarRepository>();
            mockedCarRepository.Setup(x => x.Remove(carId)).Callback(() =>
            {
                CarDetails.Remove(carToRemove);
            });

            var service = new CarService(mockedCarRepository.Object);

            service.Remove(carId);

            Assert.Equal(expectedResult, CarDetails.Count);
        }
    }
}