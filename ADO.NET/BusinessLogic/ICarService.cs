using System.Collections.Generic;

namespace BusinessLogic
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetCars();
        IEnumerable<DetailModel> GetDetails(int id);
    }
}
