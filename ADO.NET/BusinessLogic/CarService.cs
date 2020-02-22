using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class CarService : ICarService
    {
        ICarRepository carRepository = new CarRepository();

        public IEnumerable<CarModel> GetCars()
        {
            var carModels = from car in carRepository.GetCars()
                            select new CarModel() 
                            { 
                                Id = car.Id, 
                                Name = car.Name, 
                                Details = GetDetails(car.Id)
                            };
            return carModels;
        }

        public IEnumerable<DetailModel> GetDetails(int id)
        {
            var details = from detail in carRepository.GetDetails(id)
                          select new DetailModel()
                          {
                              Id = detail.Id,
                              Name = detail.Name
                          };
            return details;
        }
    }
}
