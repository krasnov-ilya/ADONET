using System.Collections.Generic;

namespace BusinessLogic
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetCars();
    }
}
