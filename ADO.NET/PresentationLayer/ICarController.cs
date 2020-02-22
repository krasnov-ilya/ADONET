using System.Collections.Generic;

namespace PresentationLayer
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetCars();
        IEnumerable<DetailViewModel> GetDetails(int id);
    }
}
