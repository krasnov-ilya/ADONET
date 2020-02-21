using System.Collections.Generic;

namespace PresentationLayer
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetDetails();
    }
}
