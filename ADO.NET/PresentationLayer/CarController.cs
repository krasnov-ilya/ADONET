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
                            detailViewModels = car.details 
                       };

            return cars;
        }
    }
}
