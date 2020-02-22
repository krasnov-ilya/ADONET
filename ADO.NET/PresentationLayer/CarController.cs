using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer
{
    public class CarController : ICarController
    {
        ICarService carService = new CarService();
        public IEnumerable<CarViewModel> GetCars()
        {
            var cars = from car in carService.GetCars()
                       select new CarViewModel() 
                       { 
                            Id = car.Id, 
                            Name = car.Name, 
                            Details = GetDetails(car.Id)
                       };

            return cars;
        }

        public IEnumerable<DetailViewModel> GetDetails(int id)
        {
            var details = from detail in carService.GetDetails(id)
                          select new DetailViewModel()
                          {
                              Id = detail.Id,
                              Name = detail.Name
                          };
            return details;
        }
    }
}
