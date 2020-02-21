using System.Collections.Generic;

namespace PresentationLayer
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetCars();
    }
}
