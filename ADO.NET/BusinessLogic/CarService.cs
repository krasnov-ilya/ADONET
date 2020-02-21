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
                            select new CarModel() { Id = car.Id, 
                                                    Name = car.Name, 
                                                    details = car.Details };
            return carModels;
        }


    }
}
